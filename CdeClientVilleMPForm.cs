/*
Programmeur: Fabrice,Perez, Kayleb
Date: Janvier 2026
Solution: CdeClientVilleMP.sln
Projet: CdeClientVilleMP.csproj
Classe: CdeClientVilleMPForm.cs
But : 

******************************* phase1: *******************************

Générer du Sql comprenant des Joins, des critères de sélection et des champs calculés. Produire une application multi niveaux la plus performante possible qui n’obtient de la base de données que les informations des clients et des commandes requises par l’application et par l’usager.

******************************* Phase2:********************************

Produire un rapport de données hiérarchiques d'un Dataset typé

******************************* Phase3:********************************

Produire un rapport d’une vue des données hiérarchiques d’un DataSet typé

Info : Base de données : Northwind local (.\sqlexpress)
Table: Customers,orders,employees 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devoir2
{
    public partial class CdeClientVilleMPForm : Form
    {
        #region Constructeur
        public CdeClientVilleMPForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Chargement des données
        private void CdeClientVilleMPForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.GetOrdersSellers(this.northwindDataSet.Orders);
                this.customersTableAdapter.GetCustomers(this.northwindDataSet.Customers);
                /*
                  SELECT O.OrderID AS [Numéro de la commande], O.OrderDate AS [Date de commande], O.RequiredDate AS [Date requise], O.CustomerID, E.FirstName + ' ' + E.LastName AS Vendeur
                    FROM   Orders AS O INNER JOIN
                     Employees AS E ON O.EmployeeID = E.EmployeeID
                ORDER BY [Date requise] DESC
                */

                /*
                 * SELECT CustomerID AS [Code du client], CompanyName AS Société, Country AS Pays, Phone AS Téléphone, City
                    FROM   Customers
                    WHERE (City LIKE 'M%') OR
                     (City LIKE 'P%')
                    ORDER BY Société DESC
                */

                //Stylisation du DataGridView et form
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                ordersDataGridView.EnableHeadersVisualStyles = false;
                ordersDataGridView.Columns[0].HeaderCell.Style.BackColor =
                ordersDataGridView.Columns[0].DefaultCellStyle.BackColor;

                //limiter la taille de la colonne largeur à la taille du contenu
                ordersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //culture pour le formatage de la date en anglais
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ordersDataGridView.Columns[1].DefaultCellStyle.FormatProvider = culture;
                ordersDataGridView.Columns[1].DefaultCellStyle.Format = "MMMM d, yyyy";
                // meme chose pour la colonne 2
                ordersDataGridView.Columns[2].DefaultCellStyle.FormatProvider = culture;
                ordersDataGridView.Columns[2].DefaultCellStyle.Format = "MMMM d, yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }


        }
        #endregion

        #region Rapport hiérarchique
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            /*
             * Produire un rapport de données hiérarchiques d'un Dataset typé.
               Clients des villes M et P et leurs commandes respectives en console writeline
               utiliser dataSet typé NorthwindDataSet.xsd
            */
            try
            {
                // 1. Remplissage des données 
                this.customersTableAdapter.GetCustomers(this.northwindDataSet.Customers);
                this.ordersTableAdapter.GetOrdersSellers(this.northwindDataSet.Orders);

                Console.WriteLine("--- Liste des Clients (M et P) et leurs commandes respectives ---" + Environment.NewLine + Environment.NewLine);

                // 2. Parcours des clients
                foreach (var customer in this.northwindDataSet.Customers)
                {
                    // Affichage des informations du client
                    Console.WriteLine(" {0,-6}  {1,-40}  {2,-15}  {3}",
                        customer.Code_du_client,
                        customer.Société,
                        customer.Pays,
                        customer.Téléphone);

                    // 3. Récupération des commandes liées via la Relatin On utilise un simple Where
                    var customerOrders = this.northwindDataSet.Orders
                                             .Where(o => o.CustomerID == customer.Code_du_client);

                    foreach (var order in customerOrders)
                    {
                        // Formatage de la date : "May 1, 2020" -> "MMMM d, yyyy"

                        string dateFormatee = order.Date_de_commande.ToString("MMMM d, yyyy", new System.Globalization.CultureInfo("en-US"));

                        // Affichage de la commande formatée
                        Console.WriteLine(String.Format("\t {0,10}  {1,-5} ",
                            order.Numéro_de_la_commande,
                            dateFormatee
                            ));
                    }

                    // ligne de séparation entre les clients pour la lisibilité
                    Console.WriteLine(new string('-', 80));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing data: " + ex.Message);
            }

        }
        #endregion

        #region Rapport hiérarchique avec filtrage
        private void filtrerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Chargement des données
                this.customersTableAdapter.GetCustomers(this.northwindDataSet.Customers);
                this.ordersTableAdapter.GetOrdersSellers(this.northwindDataSet.Orders);

                Console.WriteLine("Clients des villes M et P des État-Unis seulement et leurs commandes respectives");
                Console.WriteLine();

                // 2. Application du filtre (USA + Villes M/P)
                this.customersBindingSource.Filter = "Pays = 'USA' AND (City LIKE 'M%' OR City LIKE 'P%')";

                // 3. TRI : Ordre selon le numéro de téléphone descendant
                this.customersBindingSource.Sort = "Téléphone DESC";

                // 4. Parcours des clients triés
                for (int i = 0; i < this.customersBindingSource.Count; i++)
                {
                    this.customersBindingSource.Position = i;
                    DataRowView customerView = (DataRowView)this.customersBindingSource.Current;
                    var customer = (NorthwindDataSet.CustomersRow)customerView.Row;

                    // Affichage Parent
                    Console.WriteLine("{0,-8} {1,-45} {2,-15} {3}",
                        customer.Code_du_client,
                        customer.Société,
                        customer.Pays,
                        customer.Téléphone);

                    // 5. Filtrage et affichage des commandes (Enfants)
                    this.ordersBindingSource.Filter = "CustomerID = '" + customer.Code_du_client + "'";

                    foreach (DataRowView orderView in this.ordersBindingSource)
                    {
                        var order = (NorthwindDataSet.OrdersRow)orderView.Row;
                        string dateFormatee = order.Date_de_commande.ToString("MMMM d, yyyy",
                                              new System.Globalization.CultureInfo("en-US"));

                        Console.WriteLine("          {0,-10} {1}",
                            order.Numéro_de_la_commande,
                            dateFormatee);
                    }

                    this.ordersBindingSource.RemoveFilter();
                    Console.WriteLine();
                }

                // 6. Remise à zéro
                this.customersBindingSource.RemoveSort(); 
                this.customersBindingSource.RemoveFilter();
                this.customersBindingSource.Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'impression : " + ex.Message);
            }
        }
        #endregion
    }
}
