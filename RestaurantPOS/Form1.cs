namespace RestaurantPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FriesTb_TextChanged(object sender, EventArgs e)
        {
            FriesTb.Enabled = false;
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }
        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {
            BurgerTb.Enabled = false;
        }
        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladTb_TextChanged(object sender, EventArgs e)
        {
            SaladTb.Enabled = false;
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichTb_TextChanged(object sender, EventArgs e)
        {
            SandwichTb.Enabled = false;
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenTb_TextChanged(object sender, EventArgs e)
        {
            ChickenTb.Enabled = false;
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseTb_TextChanged(object sender, EventArgs e)
        {
            CheeseTb.Enabled = false;
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaTb_TextChanged(object sender, EventArgs e)
        {
            TeaTb.Enabled = false;
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaTb_TextChanged(object sender, EventArgs e)
        {
            ColaTb.Enabled = false;
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterTb_TextChanged(object sender, EventArgs e)
        {
            WaterTb.Enabled = false;
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateTb_TextChanged(object sender, EventArgs e)
        {
            ChocolateTb.Enabled = false;
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesTb_TextChanged(object sender, EventArgs e)
        {
            PancakesTb.Enabled = false;
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void OrangeTb_TextChanged(object sender, EventArgs e)
        {
            OrangeTb.Enabled = false;
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        //Declare unit price to different meal and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseup = 80;
        double waterup = 15, teaup = 15, colaup = 20, chocolateup = 25, pancakesup = 30;

        private void GrdTotalNum_Click(object sender, EventArgs e)
        {

        }

        public void SubtotalLbl_Click(object sender, EventArgs e)
        {
          //  double Subtotal = 0, Tax, GrdtotalLbl;
        }

        public void TaxLbl_Click(object sender, EventArgs e)
        {
          //  double Tax = 0.16; // 16% tax percentage
        }

        public void GrdTotalLbl_Click(object sender, EventArgs e)
        {
           // double Grandtotal = Subtotal + Tax;
        }

        private void TaxNum_Click(object sender, EventArgs e)
        {

        }

        private void SubTotalNum_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            WaterCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(ReceiptTb.Text + "\n\n***********************\nSubtotal " + SubtotalLbl.Text + "\nTax: " + TaxLbl.Text + "\nGrand Total " + GrdTotalLbl.Text, new Font("Century Gothic", 12, FontStyle.Regular),Brushes.Blue, new Point(130));
            e.Graphics.DrawString(ReceiptTb.Text, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(60));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n***********************\nSubtotal " + SubtotalLbl.Text + "\nTax: " + TaxLbl.Text + "\nGrand Total " + GrdTotalLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(130));
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        double orangeup = 25, chickenup = 80;
        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, cheesetp, watertp, teatp;
        double colatp, chocolatetp, pancakestp, orangetp, chickentp;
        double Subtotal = 0; //tax, grdtotal;
        double Tax = 0.16; // 16% tax percentage
        double Grdtotal = 0;
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            //Now Add Products on the Reciept
            ReceiptTb.Clear();
            Subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCODESPACE RESTAURANT\t\t" + DateLbl.Text + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*******************************" + Environment.NewLine);
            if(FriesCb.Checked == true) 
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                SubtotalLbl.Text = "" + Subtotal;
            }
            TaxLbl.Text = "" + (Tax * 100) + "%";
            GrdTotalLbl.Text = "" + (Subtotal * (1 - Tax));
        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}












