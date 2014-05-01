/*
 * Created by SharpDevelop.
 * User: CA
 * Date: 29/04/2014
 * Time: 12:33 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UserLogin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.user = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.login = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// user
			// 
			this.user.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.user.Location = new System.Drawing.Point(290, 25);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(220, 23);
			this.user.TabIndex = 0;
			this.user.Text = "Usuario";
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.password.Location = new System.Drawing.Point(290, 100);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(220, 23);
			this.password.TabIndex = 1;
			this.password.Text = "Contraseña";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(290, 51);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(220, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(290, 126);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(220, 22);
			this.textBox2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(37, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 196);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// login
			// 
			this.login.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login.ForeColor = System.Drawing.Color.Black;
			this.login.Location = new System.Drawing.Point(435, 177);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(75, 23);
			this.login.TabIndex = 5;
			this.login.Text = "Entrar";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.LoginClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(385, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 39);
			this.label1.TabIndex = 6;
			this.label1.Text = "Cervantes Acosta Daniela\r\n213266778\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(546, 251);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.user);
			this.Name = "MainForm";
			this.Text = "Mensajeria Instantanea";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button login;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label user;
	}
}
