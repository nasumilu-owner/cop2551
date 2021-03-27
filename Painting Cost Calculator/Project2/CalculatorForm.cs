using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project2
{
    /// <summary>
    /// Project2 - Simple Paint Cost Calculator
    /// 
    /// Form uses input from for cost of paint and area to be painted and
    /// caluclates the labor hours, labor cost, gallons of paint needed, 
    /// total paint cost, and total job cost. 
    /// </summary>
    public partial class PaintingCostCalculator : Form
    {
        /// <summary>
        /// Constructor for the PaintCostCalculator
        /// </summary>
        public PaintingCostCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will clear the form by seting the gallons and surface area
        /// input fields to zero.
        /// </summary>
        public void ClearForm()
        {
            surfaceAreaField.Value = 0;
            paintCostField.Value = 0;
            gallonsOfPaintField.Text = "0";
            laborHoursField.Text = "0.0";
            totalPaintCostField.Text = "$0.00";
            totalLaborCostField.Text = "$0.00";
            totalCostField.Text = "$0.00";
        }

        /// <summary>
        /// Calculate method performs the necessare calculation from the user input
        /// and update the form.
        /// 
        /// </summary>
        /// <param name="surfaceArea">The square feet of area being painted</param>
        /// <param name="paintCostPerGallon">The cost per gallon of paint</param>
        public void Calculate(decimal surfaceArea, decimal paintCostPerGallon)
        {
            int gallonsOfPaint = CalculateGallonsOfPaintNeeded(surfaceArea);
            gallonsOfPaintField.Text = gallonsOfPaint.ToString();
            decimal laborHours = CalculateLaborHours(surfaceArea);
            laborHoursField.Text = laborHours.ToString("N1");
            decimal totalPaintCost = CalculateCostOfPaint(paintCostPerGallon, gallonsOfPaint);
            totalPaintCostField.Text = totalPaintCost.ToString("C2");
            decimal totalLaborCost = CalculateLaborCost(laborHours);
            totalLaborCostField.Text = totalLaborCost.ToString("C2");
            totalCostField.Text = CalculateTotalCost(totalLaborCost, totalPaintCost).ToString("C2");
        }

        /// <summary>
        /// Calculate sthe gallons of paint need from a variable surface area in square feet.
        /// 
        /// This method hard codes a factor of 115 square feet per gallon of paint and will
        /// always return whole gallons as an integer. 
        /// 
        /// </summary>
        /// <param name="surfaceArea">The surface are being painted in square feet</param>
        /// <returns></returns>
        public int CalculateGallonsOfPaintNeeded(decimal surfaceArea)
        {
            decimal amount = surfaceArea / 115;
            return (int) Math.Ceiling(amount);
        }

        /// <summary>
        /// Calcultes the amount of labor in hour need to paint a variable surface area in 
        /// square feet. 
        /// 
        /// This method hard codes a factor of 115 square feet per 8 man hours.
        /// 
        /// </summary>
        /// <param name="surfaceArea"></param>
        /// <returns></returns>
        public decimal CalculateLaborHours(decimal surfaceArea)
        {
            decimal amount = surfaceArea / 115;
            return amount * 8;
        }

        /// <summary>
        /// Calculates the cost of paint from the variable paint cost and number of 
        /// gallons. 
        /// 
        /// </summary>
        /// <param name="paintCost">The paint cost</param>
        /// <param name="gallonsOfPaint">The number of whole gallons</param>
        /// <returns></returns>
        public decimal CalculateCostOfPaint(decimal paintCost, int gallonsOfPaint)
        {
            return gallonsOfPaint * paintCost;
        }

        /// <summary>
        /// Caluglate the labor cost from the variable number of man hours.
        /// 
        /// The labor cost of $20.oo is hard coded, so I can get some extra
        /// dollars becuase inflation happens to us all.
        /// 
        /// </summary>
        /// <param name="laborHours">The number of man hours</param>
        /// <returns></returns>
        public decimal CalculateLaborCost(decimal laborHours)
        {
            return laborHours * 20;
        }

        /// <summary>
        /// Calculates the total cost from a variable labor and paint cost.
        /// </summary>
        /// <param name="laborCost">The total labor cost</param>
        /// <param name="paintCost">The totla paint cost</param>
        /// <returns></returns>
        public decimal CalculateTotalCost(decimal laborCost, decimal paintCost)
        {
            return laborCost + paintCost;
        }

        /// <summary>
        /// EventHandler when the user clicks the exit button.
        /// 
        /// The user is given a second opportunity to descide if they would
        /// like to exit via MessageBox. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you would like to quit?", "Quit", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// EventHandler when the user clicks the calculate button. 
        /// 
        /// If either the paint cost or surface are fields are zero (not valid)
        /// the user is presented with a error MessageBox and focus is sent to
        /// the paint cost field.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!this.Valid)
            {
                MessageBox.Show(this, "Please input a valid paint cost and surface area", "Invalid Input", MessageBoxButtons.OK);
                paintCostField.Focus();
            }
            else
            {
                Calculate(surfaceAreaField.Value, paintCostField.Value);
            }
        }

        /// <summary>
        /// Indicates whether the form is valid or not
        /// 
        /// For the form to be valid both the surface area nad paint cost fields
        /// must be greater than zero.
        /// 
        /// </summary>
        public bool Valid
        {
            get => surfaceAreaField.Value > 0 && paintCostField.Value > 0;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Selects the value when entering the paint cost or surface are fields.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectValue_Enter(object sender, EventArgs e)
        {
            NumericUpDown field = (NumericUpDown)sender;
            if (!String.IsNullOrEmpty(field.Text))
            {
                field.Select(0, field.Text.Length);
            }
        }
    }
}
