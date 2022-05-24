
namespace VehicleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbCarBrand = new System.Windows.Forms.Label();
            this.lbCarModel = new System.Windows.Forms.Label();
            this.cbVehicleClass = new System.Windows.Forms.ComboBox();
            this.cbCarBrand = new System.Windows.Forms.ComboBox();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.btnDescribeMe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(17, 30);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(97, 19);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "Level Class";
            // 
            // lbCarBrand
            // 
            this.lbCarBrand.AutoSize = true;
            this.lbCarBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarBrand.Location = new System.Drawing.Point(254, 30);
            this.lbCarBrand.Name = "lbCarBrand";
            this.lbCarBrand.Size = new System.Drawing.Size(56, 19);
            this.lbCarBrand.TabIndex = 1;
            this.lbCarBrand.Text = "Brand";
            this.lbCarBrand.Visible = false;
            // 
            // lbCarModel
            // 
            this.lbCarModel.AutoSize = true;
            this.lbCarModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarModel.Location = new System.Drawing.Point(474, 30);
            this.lbCarModel.Name = "lbCarModel";
            this.lbCarModel.Size = new System.Drawing.Size(55, 19);
            this.lbCarModel.TabIndex = 2;
            this.lbCarModel.Text = "Model";
            this.lbCarModel.Visible = false;
            // 
            // cbVehicleClass
            // 
            this.cbVehicleClass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicleClass.FormattingEnabled = true;
            this.cbVehicleClass.Items.AddRange(new object[] {
            "Luxurious\t",
            "Economic",
            "Compact"});
            this.cbVehicleClass.Location = new System.Drawing.Point(12, 66);
            this.cbVehicleClass.Name = "cbVehicleClass";
            this.cbVehicleClass.Size = new System.Drawing.Size(121, 24);
            this.cbVehicleClass.TabIndex = 3;
            this.cbVehicleClass.SelectedIndexChanged += new System.EventHandler(this.cbVehicleClass_SelectedIndexChanged);
            // 
            // cbCarBrand
            // 
            this.cbCarBrand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarBrand.FormattingEnabled = true;
            this.cbCarBrand.Location = new System.Drawing.Point(231, 66);
            this.cbCarBrand.Name = "cbCarBrand";
            this.cbCarBrand.Size = new System.Drawing.Size(121, 24);
            this.cbCarBrand.TabIndex = 4;
            this.cbCarBrand.Visible = false;
            this.cbCarBrand.SelectedIndexChanged += new System.EventHandler(this.cbCarBrand_SelectedIndexChanged);
            // 
            // cbCarModel
            // 
            this.cbCarModel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Location = new System.Drawing.Point(446, 66);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(121, 24);
            this.cbCarModel.TabIndex = 5;
            this.cbCarModel.Visible = false;
            // 
            // btnDescribeMe
            // 
            this.btnDescribeMe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescribeMe.Location = new System.Drawing.Point(318, 345);
            this.btnDescribeMe.Name = "btnDescribeMe";
            this.btnDescribeMe.Size = new System.Drawing.Size(144, 34);
            this.btnDescribeMe.TabIndex = 6;
            this.btnDescribeMe.Text = "Describe ";
            this.btnDescribeMe.UseVisualStyleBackColor = true;
            this.btnDescribeMe.Click += new System.EventHandler(this.btnDescribeMe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCarModel);
            this.groupBox1.Controls.Add(this.lbLevel);
            this.groupBox1.Controls.Add(this.lbCarBrand);
            this.groupBox1.Controls.Add(this.lbCarModel);
            this.groupBox1.Controls.Add(this.cbCarBrand);
            this.groupBox1.Controls.Add(this.cbVehicleClass);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Car";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribe.Location = new System.Drawing.Point(122, 196);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(563, 110);
            this.txtDescribe.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(122, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(128, 19);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Car Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDescribeMe);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vehicle Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbCarBrand;
        private System.Windows.Forms.Label lbCarModel;
        private System.Windows.Forms.ComboBox cbVehicleClass;
        private System.Windows.Forms.ComboBox cbCarBrand;
        private System.Windows.Forms.ComboBox cbCarModel;
        private System.Windows.Forms.Button btnDescribeMe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label lblDescription;
    }
}