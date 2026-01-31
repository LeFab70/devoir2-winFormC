/*
Programmeur: Fabrice,Perez, Kayleb
Date: Janvier 2026
Solution: CdeClientVilleMP.sln
Projet: CdeClientVilleMP.csproj
Classe: CdeClientVilleMPForm.cs
But : Générer du Sql comprenant des Joins, des critères de sélection et des champs calculés. Produire une application multi niveaux la plus performante possible qui n’obtient de la base de données que les informations des clients et des commandes requises par l’application et par l’usager.
Info : Base de données : Northwind local (.\sqlexpress)
Table: Customers,orders,employees 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                /*
                 * SELECT CustomerID AS [Code du client], CompanyName AS Société, Country AS Pays, Phone AS Téléphone, City
                    FROM   Customers
                    WHERE (City LIKE 'M%') OR
                     (City LIKE 'P%')
                    ORDER BY Société DESC
                */

                this.ordersTableAdapter.GetOrdersSellers(this.northwindDataSet.Orders);


                /*
                 * SELECT O.OrderID AS [Numéro de la commande], O.OrderDate AS [Date de commande], O.RequiredDate AS [Date requise], O.CustomerID, E.FirstName + ' ' + E.LastName AS Vendeur
                    FROM   Orders AS O INNER JOIN
                     Employees AS E ON O.EmployeeID = E.EmployeeID
                ORDER BY [Date requise] DESC
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
    }
}
