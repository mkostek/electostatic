using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace elips_buton_olusturma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		public struct iletken
		{
			public double yuk;
			public double yarıcap;
		}
		iletken a,b;
		double r=0.5;
		bool suruklenmedurumu = false; //Class seviyesinde bir field(değişken) tanımlıyoruz ki,MouseDown da biz bunu true yapacağız,MouseUpta false değerini alacak ve MouseMove eventında true ise hareket edecek.
		Point ilkkonum; //Global bir değişken tanımlıyoruz ki, ilk tıkladığımız andaki konumunu çıkarmadığımızda buton mouse imlecinden daha aşağıdan hareket edecektir.
		private void Down(object sender, MouseEventArgs e)
		{
			suruklenmedurumu = true; //işlemi burada true diyerek başlatıyoruz.
			((ShapedButton)sender).Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü vermek için
			ilkkonum = e.Location; //İlk konuma gördüğünüz gibi değerimizi atıyoruz.
			
		}
		private void Move(object sender, MouseEventArgs e)
		{
			if (suruklenmedurumu) // suruklenmedurumu==true ile aynı.
			{
				((ShapedButton)sender).Left = e.X + ((ShapedButton)sender).Left - (ilkkonum.X);
				// button.left ile soldan uzaklığını ayarlıyoruz. Yani e.X dediğimizde buton üzerinde mouseun hareket ettiği pixeli alacağız + butonun soldan uzaklığını ekliyoruz son olarakta ilk mouseın tıklandığı alanı çıkarıyoruz yoksa butonun en solunda olur mouse imleci. Alttakide aynı şekilde Y koordinati için geçerli
				((ShapedButton)sender).Top = e.Y + ((ShapedButton)sender).Top - (ilkkonum.Y);
				chart1.Series[0].Points.Add(kuvvet());
			}
			
		}
		private void Up(object sender, MouseEventArgs e)
		{
			suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
			((ShapedButton)sender).Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
		}
		public double denge()
		{
			return (a.yuk+b.yuk)/(a.yarıcap+b.yarıcap);
		}
		public int mesafe()
		{
			return	(int)Math.Sqrt(Math.Pow(shapedButton1.Location.X-shapedButton2.Location.X,2)+Math.Pow(shapedButton2.Location.Y-shapedButton1.Location.Y,2));
		}
		public int kuvvet()
		{
			return (int)(9*(Math.Pow(10,9)*(a.yuk*b.yuk)/Math.Pow(mesafe(),2)));
		}
		private void Form1_Load(object sender, EventArgs e)
		{/*
            ShapedButton elips_Buton = new ShapedButton();
            elips_Buton.Location = new Point(120, 60);
            elips_Buton.FlatAppearance.BorderSize = 0;
            elips_Buton.BackColor = Color.Blue;
            elips_Buton.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(elips_Buton);*/
			timer1.Start();
		}
		public void hesaplama()
		{
			
			if(a.yuk>denge()*a.yarıcap)
			{
				a.yuk-=r;b.yuk+=r;
			}
			else if(a.yuk<denge()*a.yarıcap)
			{
				a.yuk+=r;b.yuk-=r;

			}
			shapedButton2.Text="yük:"+a.yuk+"\nyarıçap:"+a.yarıcap;
			chartBirinciDerece.Series[0].Points.Add(a.yuk);
			shapedButton1.Text="yük:"+b.yuk+"\nyarıçap:"+b.yarıcap;
			chartBirinciDerece.Series[1].Points.Add(b.yuk);
			chart1.Series[0].Points.Add(kuvvet());

		}

		public bool kontrol(Button b1,Button b2)
		{
			int a,b,c,d;
			a=(b1.Right-b2.Left)*(b2.Bottom-b1.Top);
			b=(b1.Bottom-b2.Top)*(b1.Right-b2.Left);
			c=(b1.Bottom-b2.Top)*(b2.Right-b1.Left);
			d=(b2.Bottom-b1.Top)*(b2.Right-b1.Left);
			if(a>0&&b>0&&c>0&&d>0)
				return true;
			else return false;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(kontrol(shapedButton1,shapedButton2)){
				hesaplama();
			}
			
		}

		void Button1Click(object sender, EventArgs e)
		{
			switch(comboBox1.SelectedIndex){
					case 0:a.yarıcap=Convert.ToDouble(textBox1.Text);
					a.yuk=Convert.ToDouble(textBox2.Text);
					shapedButton2.Width=(int)a.yarıcap*50;
					shapedButton2.Height=(int)a.yarıcap*50;
					shapedButton2.Text="yük:"+a.yuk+"\nyarıçap:"+a.yarıcap;
					break;
					case 1:b.yarıcap=Convert.ToDouble(textBox1.Text);
					b.yuk=Convert.ToDouble(textBox2.Text);
					shapedButton1.Width=(int)b.yarıcap*50;
					shapedButton1.Height=(int)b.yarıcap*50;
					shapedButton1.Text="yük:"+b.yuk+"\nyarıçap:"+b.yarıcap;
					break;
					default:break;
			}
			chartBirinciDerece.Series[0].Points.Clear();
			chartBirinciDerece.Series[1].Points.Clear();
			
			chart1.Series[0].Points.Clear();
		}
	}
	public class ShapedButton : Button //Buton sınıfından miras alınıyor
	{
		// Elips buton a yeni bir boyut  verildiğinde şeklini elips yapıyor
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			GraphicsPath gp = new GraphicsPath();
			// this.Size ın en boyu aynı oldugundan elips bir şekil oluşuyor
			gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
			// oluşan yeni elips şekli oluşturulan butona atanıyor
			this.Region = new Region(gp);
			// Butonun yeni şekli elips oluyor
		}
	}
}
