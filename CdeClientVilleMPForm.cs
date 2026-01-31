/*
Programmeur: Fabrice,Perez, Kayleb
Date: Janvier 2026
Solution: CdeClientVilleMP.sln
Projet: CdeClientVilleMP.csproj
Classe: CdeClientVilleMPForm.cs
But : 

******************************* phase1: ***********************************

Générer du Sql comprenant des Joins, des critères de sélection et des champs calculés. Produire une application multi niveaux la plus performante possible qui n’obtient de la base de données que les informations des clients et des commandes requises par l’application et par l’usager.

******************************* Phase2:********************************

Produire un rapport de données hiérarchiques d'un Dataset typé


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
        public CdeClientVilleMPForm()
        {
            InitializeComponent();
        }

        private void CdeClientVilleMPForm_Load(object sender, EventArgs e)
        {
            
           
            try
            {
                

                this.ordersTableAdapter.GetOrdersSellers(this.northwindDataSet.Orders);


                /*
                 * SELECT O.OrderID AS [Numéro de la commande], O.OrderDate AS [Date de commande], O.RequiredDate AS [Date requise], O.CustomerID, E.FirstName + ' ' + E.LastName AS Vendeur
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
                this.customersTableAdapter.GetCustomers(this.northwindDataSet.Customers);

                //Stylisation du DataGridView et form
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                ordersDataGridView.EnableHeadersVisualStyles = false;
                ordersDataGridView.Columns[0].HeaderCell.Style.BackColor =
                ordersDataGridView.Columns[0].DefaultCellStyle.BackColor;

                //limiter la taille de la colonne largeur à la taille du contenu
                ordersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            

        }

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

                Console.WriteLine("--- Liste des Clients (M et P) et leurs commandes respectives ---"+Environment.NewLine+Environment.NewLine);

                // 2. Parcours des clients
                foreach (var customer in this.northwindDataSet.Customers)
                {
                    // Affichage des informations du client
                    Console.WriteLine(" {0}  {1}  {2,-10}  {3,-2}",
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
    }
}
