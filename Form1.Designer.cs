namespace Project4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFlavor = new System.Windows.Forms.GroupBox();
            this.radioButtonStrawberry = new System.Windows.Forms.RadioButton();
            this.radioButtonVanilla = new System.Windows.Forms.RadioButton();
            this.radioButtonChocolate = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxCherry = new System.Windows.Forms.CheckBox();
            this.checkBoxChoppedNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.groupBoxFlavor.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFlavor
            // 
            this.groupBoxFlavor.Controls.Add(this.radioButtonStrawberry);
            this.groupBoxFlavor.Controls.Add(this.radioButtonVanilla);
            this.groupBoxFlavor.Controls.Add(this.radioButtonChocolate);
            this.groupBoxFlavor.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFlavor.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFlavor.Name = "groupBoxFlavor";
            this.groupBoxFlavor.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFlavor.Size = new System.Drawing.Size(107, 118);
            this.groupBoxFlavor.TabIndex = 0;
            this.groupBoxFlavor.TabStop = false;
            this.groupBoxFlavor.Text = "Flavor";
            this.groupBoxFlavor.Enter += new System.EventHandler(this.groupBoxFlavor_Enter);
            // 
            // radioButtonStrawberry
            // 
            this.radioButtonStrawberry.AutoSize = true;
            this.radioButtonStrawberry.Location = new System.Drawing.Point(15, 88);
            this.radioButtonStrawberry.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStrawberry.Name = "radioButtonStrawberry";
            this.radioButtonStrawberry.Size = new System.Drawing.Size(75, 17);
            this.radioButtonStrawberry.TabIndex = 2;
            this.radioButtonStrawberry.TabStop = true;
            this.radioButtonStrawberry.Text = "Strawberry";
            this.radioButtonStrawberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonVanilla
            // 
            this.radioButtonVanilla.AutoSize = true;
            this.radioButtonVanilla.Location = new System.Drawing.Point(15, 57);
            this.radioButtonVanilla.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonVanilla.Name = "radioButtonVanilla";
            this.radioButtonVanilla.Size = new System.Drawing.Size(56, 17);
            this.radioButtonVanilla.TabIndex = 1;
            this.radioButtonVanilla.TabStop = true;
            this.radioButtonVanilla.Text = "Vanilla";
            this.radioButtonVanilla.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolate
            // 
            this.radioButtonChocolate.AutoSize = true;
            this.radioButtonChocolate.Location = new System.Drawing.Point(15, 27);
            this.radioButtonChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonChocolate.Name = "radioButtonChocolate";
            this.radioButtonChocolate.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChocolate.TabIndex = 0;
            this.radioButtonChocolate.TabStop = true;
            this.radioButtonChocolate.Text = "Chocolate";
            this.radioButtonChocolate.UseVisualStyleBackColor = true;
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxCherry);
            this.groupBoxToppings.Controls.Add(this.checkBoxChoppedNuts);
            this.groupBoxToppings.Controls.Add(this.checkBoxSprinkles);
            this.groupBoxToppings.Location = new System.Drawing.Point(151, 20);
            this.groupBoxToppings.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Size = new System.Drawing.Size(118, 118);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxCherry
            // 
            this.checkBoxCherry.AutoSize = true;
            this.checkBoxCherry.Location = new System.Drawing.Point(11, 88);
            this.checkBoxCherry.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCherry.Name = "checkBoxCherry";
            this.checkBoxCherry.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCherry.TabIndex = 2;
            this.checkBoxCherry.Text = "Cherry";
            this.checkBoxCherry.UseVisualStyleBackColor = true;
            // 
            // checkBoxChoppedNuts
            // 
            this.checkBoxChoppedNuts.AutoSize = true;
            this.checkBoxChoppedNuts.Location = new System.Drawing.Point(11, 57);
            this.checkBoxChoppedNuts.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxChoppedNuts.Name = "checkBoxChoppedNuts";
            this.checkBoxChoppedNuts.Size = new System.Drawing.Size(94, 17);
            this.checkBoxChoppedNuts.TabIndex = 1;
            this.checkBoxChoppedNuts.Text = "Chopped Nuts";
            this.checkBoxChoppedNuts.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.Location = new System.Drawing.Point(11, 27);
            this.checkBoxSprinkles.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSprinkles.TabIndex = 0;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.Location = new System.Drawing.Point(20, 158);
            this.buttonTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(107, 35);
            this.buttonTotalPrice.TabIndex = 2;
            this.buttonTotalPrice.Text = "Total Price";
            this.buttonTotalPrice.UseVisualStyleBackColor = true;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPrice.Location = new System.Drawing.Point(151, 158);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(118, 35);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 226);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonTotalPrice);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxFlavor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ice Cream Shop";
            this.groupBoxFlavor.ResumeLayout(false);
            this.groupBoxFlavor.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFlavor;
        private System.Windows.Forms.RadioButton radioButtonStrawberry;
        private System.Windows.Forms.RadioButton radioButtonVanilla;
        private System.Windows.Forms.RadioButton radioButtonChocolate;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxCherry;
        private System.Windows.Forms.CheckBox checkBoxChoppedNuts;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}

