namespace Cave
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
            this.btnConstructor = new System.Windows.Forms.Button();
            this.btnNeighbors = new System.Windows.Forms.Button();
            this.btnDoors = new System.Windows.Forms.Button();
            this.lblNeighbors = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.btnDrawCave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConstructor
            // 
            this.btnConstructor.Location = new System.Drawing.Point(32, 33);
            this.btnConstructor.Name = "btnConstructor";
            this.btnConstructor.Size = new System.Drawing.Size(126, 23);
            this.btnConstructor.TabIndex = 0;
            this.btnConstructor.Text = "Create Cave Object";
            this.btnConstructor.UseVisualStyleBackColor = true;
            this.btnConstructor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNeighbors
            // 
            this.btnNeighbors.Location = new System.Drawing.Point(32, 73);
            this.btnNeighbors.Name = "btnNeighbors";
            this.btnNeighbors.Size = new System.Drawing.Size(126, 23);
            this.btnNeighbors.TabIndex = 1;
            this.btnNeighbors.Text = "Get Neighbors";
            this.btnNeighbors.UseVisualStyleBackColor = true;
            this.btnNeighbors.Click += new System.EventHandler(this.btnNeighbors_Click);
            // 
            // btnDoors
            // 
            this.btnDoors.Location = new System.Drawing.Point(32, 111);
            this.btnDoors.Name = "btnDoors";
            this.btnDoors.Size = new System.Drawing.Size(126, 23);
            this.btnDoors.TabIndex = 2;
            this.btnDoors.Text = "Get Doors";
            this.btnDoors.UseVisualStyleBackColor = true;
            this.btnDoors.Click += new System.EventHandler(this.btnDoors_Click);
            // 
            // lblNeighbors
            // 
            this.lblNeighbors.AutoSize = true;
            this.lblNeighbors.Location = new System.Drawing.Point(177, 82);
            this.lblNeighbors.Name = "lblNeighbors";
            this.lblNeighbors.Size = new System.Drawing.Size(35, 13);
            this.lblNeighbors.TabIndex = 3;
            this.lblNeighbors.Text = "empty";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(177, 116);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(35, 13);
            this.lblDoors.TabIndex = 4;
            this.lblDoors.Text = "empty";
            // 
            // btnDrawCave
            // 
            this.btnDrawCave.Location = new System.Drawing.Point(32, 151);
            this.btnDrawCave.Name = "btnDrawCave";
            this.btnDrawCave.Size = new System.Drawing.Size(126, 23);
            this.btnDrawCave.TabIndex = 5;
            this.btnDrawCave.Text = "Draw Cave";
            this.btnDrawCave.UseVisualStyleBackColor = true;
            this.btnDrawCave.Click += new System.EventHandler(this.btnDrawCave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 218);
            this.Controls.Add(this.btnDrawCave);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.lblNeighbors);
            this.Controls.Add(this.btnDoors);
            this.Controls.Add(this.btnNeighbors);
            this.Controls.Add(this.btnConstructor);
            this.Name = "Form1";
            this.Text = "Test Cave Object";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConstructor;
        private System.Windows.Forms.Button btnNeighbors;
        private System.Windows.Forms.Button btnDoors;
        private System.Windows.Forms.Label lblNeighbors;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Button btnDrawCave;
    }
}

