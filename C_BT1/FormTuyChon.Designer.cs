namespace C_BT1
{
    partial class FormTuyChon
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
            this.grpChon = new System.Windows.Forms.GroupBox();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grpChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdMaSo);
            this.grpChon.Controls.Add(this.rdHoTen);
            this.grpChon.Controls.Add(this.rdSoDT);
            this.grpChon.Location = new System.Drawing.Point(20, 30);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new System.Drawing.Size(200, 120);
            this.grpChon.TabIndex = 0;
            this.grpChon.TabStop = false;
            this.grpChon.Text = "Chọn tiêu chí";
            // 
            // rdMaSo
            // 
            this.rdMaSo.AutoSize = true;
            this.rdMaSo.Checked = true;
            this.rdMaSo.Location = new System.Drawing.Point(20, 30);
            this.rdMaSo.Name = "rdMaSo";
            this.rdMaSo.Size = new System.Drawing.Size(73, 20);
            this.rdMaSo.TabIndex = 0;
            this.rdMaSo.TabStop = true;
            this.rdMaSo.Text = "Mã số";
            this.rdMaSo.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(20, 60);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(78, 20);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Location = new System.Drawing.Point(20, 90);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(99, 20);
            this.rdSoDT.TabIndex = 2;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(20, 170);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(200, 22);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(80, 210);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmTuyChonTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.grpChon);
            this.Name = "frmTuyChonTim";
            this.Text = "Tìm kiếm";
            this.grpChon.ResumeLayout(false);
            this.grpChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton rdMaSo;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTim;
        #endregion
    }
}