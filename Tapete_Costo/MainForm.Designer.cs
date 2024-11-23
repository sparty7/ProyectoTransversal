/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 21/11/2024
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tapete_Costo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tam;
		private System.Windows.Forms.TextBox per;
		private System.Windows.Forms.Label Costo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		
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
			this.tam = new System.Windows.Forms.TextBox();
			this.per = new System.Windows.Forms.TextBox();
			this.Costo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tam
			// 
			this.tam.Location = new System.Drawing.Point(68, 64);
			this.tam.Name = "tam";
			this.tam.Size = new System.Drawing.Size(100, 20);
			this.tam.TabIndex = 0;
			// 
			// per
			// 
			this.per.Location = new System.Drawing.Point(300, 64);
			this.per.Name = "per";
			this.per.Size = new System.Drawing.Size(100, 20);
			this.per.TabIndex = 1;
			// 
			// Costo
			// 
			this.Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Costo.Location = new System.Drawing.Point(68, 211);
			this.Costo.Name = "Costo";
			this.Costo.Size = new System.Drawing.Size(166, 25);
			this.Costo.TabIndex = 2;
			this.Costo.Text = "$";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(58, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tamaño del tapete (m^2)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(265, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cantidad de personas trabajando";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(193, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(68, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "COSTO:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 276);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Costo);
			this.Controls.Add(this.per);
			this.Controls.Add(this.tam);
			this.Name = "MainForm";
			this.Text = "Tapete_Costo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
