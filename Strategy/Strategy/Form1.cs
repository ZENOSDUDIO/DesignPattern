using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        private double totalResult = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Ver 2
            //cmbType.Items.AddRange(new string[] { "No Discount", "20% Off", "30% Off", "50% Off" });
            //cmbType.SelectedIndex = 0;
            #endregion

            #region Ver 3
            //cmbType.Items.AddRange(new string[] { "No Discount", "20% Off", "30% Off", "50% Off", "Return 200 When 500" });
            //cmbType.SelectedIndex = 0;
            #endregion
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            #region Ver 1
            double totalPrice = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            totalResult += totalPrice;

            lstItems.Items.Add(string.Format("Unit price: {0}, Quantity: {1}, Item Amount: {2}.", txtUnitPrice.Text, txtQuantity.Text, totalPrice));
            lblTotalResult.Text = totalResult.ToString();
            #endregion

            #region Ver 2
            //double totalPrice = 0d;

            //switch (cmbType.SelectedIndex)
            //{
            //    case 0:
            //        totalPrice = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            //        break;
            //    case 1:
            //        totalPrice = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text) * 0.8;
            //        break;
            //    case 2:
            //        totalPrice = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text) * 0.7;
            //        break;
            //    case 3:
            //        totalPrice = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text) * 0.5;
            //        break;
            //}

            //totalResult += totalPrice;

            //lstItems.Items.Add(string.Format("Unit price: {0}, Quantity: {1}, Item Amount: {2}.", txtUnitPrice.Text, txtQuantity.Text, totalPrice));
            //lblTotalResult.Text = totalResult.ToString();
            #endregion

            #region Ver 3
            //CashSuper cash = CashFactory.CreateCashAccept((ChargeType)cmbType.SelectedIndex);
            //double totalPrice = cash.AcceptCash(Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text));

            //totalResult += totalPrice;

            //lstItems.Items.Add(string.Format("Unit price: {0}, Quantity: {1}, Item Amount: {2}.", txtUnitPrice.Text, txtQuantity.Text, totalPrice));
            //lblTotalResult.Text = totalResult.ToString();
            #endregion

            #region Ver 4
            //CashContext cc = null;

            //switch (cmbType.SelectedIndex)
            //{
            //    case (int)ChargeType.NoDiscount:
            //        cc = new CashContext(new CashNormal());
            //        break;
            //    case (int)ChargeType.With20Off:
            //        cc = new CashContext(new CashDiscount(0.8));
            //        break;
            //    case (int)ChargeType.With30Off:
            //        cc = new CashContext(new CashDiscount(0.7));
            //        break;
            //    case (int)ChargeType.With50Off:
            //        cc = new CashContext(new CashDiscount(0.5));
            //        break;
            //    case (int)ChargeType.Return200When500:
            //        cc = new CashContext(new CashReturn(500, 200));
            //        break;
            //}

            //double totalPrice = cc.GetResult(Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text));

            //totalResult += totalPrice;

            //lstItems.Items.Add(string.Format("Unit price: {0}, Quantity: {1}, Item Amount: {2}.", txtUnitPrice.Text, txtQuantity.Text, totalPrice));
            //lblTotalResult.Text = totalResult.ToString();
            #endregion

            #region Ver 5
            //var cc = new CashContext((ChargeType)cmbType.SelectedIndex);
            //double totalPrice = cc.GetResult(Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text));

            //totalResult += totalPrice;

            //lstItems.Items.Add(string.Format("Unit price: {0}, Quantity: {1}, Item Amount: {2}.", txtUnitPrice.Text, txtQuantity.Text, totalPrice));
            //lblTotalResult.Text = totalResult.ToString();
            #endregion
        }
    }
}
