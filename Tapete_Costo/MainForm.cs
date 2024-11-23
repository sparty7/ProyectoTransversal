/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 21/11/2024
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
/*
#include <bits/stdc++.h>
using namespace std;
#define ll long long 
-leer los datos
- 2 kg de aserrín por metro cuadrado (150 pesos el bulto con 25kg aprox).
- 150 g de pintura por metro cuadrado (100 pesos el litro aprox).
- 200 g de frutos secos por metro cuadrado (210 pesos por kg).
- 2 docenas de flores por metro cuadrado (45 pesos por docena).
- 2 litros por metro cuadrado (0,04 pesos el litro).
- costo por hora de tiempo de diseño por personas: 700 pesos.
- costo de mano de obra por cantidad de personas: 800 pesos .
int main() {
    ingresa el tamaño, los costos de los elementos, y la cantidad de personas. 
    ll t,p;
    double ans = 0;
    cin >> t >> p;
    double pas = ((t * 2) / 25)*150;
    double ppin = ((150 * t) / 1000)*100;
    double pfru = ((200 * t) / 1000)*210;
    double pflo = 2*t*45;
    double pagu = (2*t)*0.04;
    double cphdd = t <= 10? 700 * p : 900 * p;
    double cdmdo = t <= 10? 800 * p : 1000 * p;
    ans += pas + ppin + pfru + pflo + pagu + cphdd + cdmdo;
    cout << "$" << ans << " aprox\n";
}
*/
namespace Tapete_Costo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int t,p;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			t = Int32.Parse(tam.Text);
			p = Int32.Parse(per.Text);
			double ans = 0;
		    double pas = ((t * 2) / 25)*150;
		    double ppin = ((150 * t) / 1000)*100;
		    double pfru = ((200 * t) / 1000)*210;
		    double pflo = 2*t*45;
		    double pagu = (2*t)*0.04;
		    double cphdd = t <= 10? 700 * p : 900 * p;
		    double cdmdo = t <= 10? 400 * p : 600 * p;
		    ans += pas + ppin + pfru + pflo + pagu + cphdd + cdmdo;
		    Costo.Text = '$' + ans.ToString() + " aprox";
		}
	}
}
