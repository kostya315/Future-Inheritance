using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace Feature_Inheritance
{
	public class MainWindow : Window, IComponentConnector
	{
		public MainWindow()
		{
			this.InitializeComponent();
			this.PennetWindow.Visibility = Visibility.Collapsed;
			this.waittostart();
		}

		private void waittostart()
		{
			DispatcherTimer timer = new DispatcherTimer();
			timer.Tick += this.CollapseHello;
			timer.Interval = new TimeSpan(0, 0, 6);
			timer.Start();
		}

		private void CollapseHello(object sender, EventArgs e)
		{
			this.Hello.Visibility = Visibility.Collapsed;
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			base.DragMove();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.<>c__DisplayClass5_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			this.f = false;
			CS$<>8__locals1.er = false;
			this.error1.Text = "";
			string child = "";
			CS$<>8__locals1.woman = this.womano1.Text;
			CS$<>8__locals1.man = this.mano1.Text;
			CS$<>8__locals1.woms = CS$<>8__locals1.woman.ToCharArray();
			CS$<>8__locals1.mans = CS$<>8__locals1.man.ToCharArray();
			int numlet = CS$<>8__locals1.mans.Length / 2;
			CS$<>8__locals1.smwom = new char[CS$<>8__locals1.woms.Length];
			CS$<>8__locals1.smman = new char[CS$<>8__locals1.mans.Length];
			for (int i = 0; i < CS$<>8__locals1.woms.Length; i++)
			{
				CS$<>8__locals1.smwom[i] = char.ToLower(CS$<>8__locals1.woms[i]);
			}
			for (int j = 0; j < CS$<>8__locals1.mans.Length; j++)
			{
				CS$<>8__locals1.smman[j] = char.ToLower(CS$<>8__locals1.mans[j]);
			}
			this.<Button_Click>g__ErrorChek|5_1(ref CS$<>8__locals1);
			bool flag = this.womano1.Text != "" && this.mano1.Text != "" && !CS$<>8__locals1.er;
			if (flag)
			{
				bool flag2 = CS$<>8__locals1.woman.Length == 2;
				if (flag2)
				{
					bool flag3 = !CS$<>8__locals1.er;
					if (flag3)
					{
						for (int k = 0; k < CS$<>8__locals1.smwom.Length / 2; k++)
						{
							for (int a = 1; a < CS$<>8__locals1.smwom.Length; a += 2)
							{
								bool flag4 = CS$<>8__locals1.smwom[k + a] <= CS$<>8__locals1.smwom[CS$<>8__locals1.smwom.Length - a];
								if (flag4)
								{
									bool flag5 = CS$<>8__locals1.smwom[k] != CS$<>8__locals1.smwom[k + a];
									if (flag5)
									{
										this.error1.Text = "Ошибка!\nАллели не могут иметь вид \"AB\"";
										CS$<>8__locals1.er = true;
									}
								}
							}
						}
					}
					bool flag6 = !CS$<>8__locals1.er;
					if (flag6)
					{
						for (int l = 0; l < CS$<>8__locals1.smman.Length / 2; l++)
						{
							for (int a2 = 1; a2 < CS$<>8__locals1.smman.Length; a2 += 2)
							{
								bool flag7 = CS$<>8__locals1.smman[l + a2] <= CS$<>8__locals1.smman[CS$<>8__locals1.smman.Length - a2];
								if (flag7)
								{
									bool flag8 = CS$<>8__locals1.smman[l] != CS$<>8__locals1.smman[l + a2];
									if (flag8)
									{
										this.error1.Text = "Ошибка!\nАллели не могут иметь вид \"AB\"";
										CS$<>8__locals1.er = true;
									}
								}
							}
						}
					}
					bool flag9 = !CS$<>8__locals1.er;
					if (flag9)
					{
						for (int m = 0; m < CS$<>8__locals1.smman.Length; m++)
						{
							bool flag10 = CS$<>8__locals1.smman[m] != CS$<>8__locals1.smwom[m];
							if (flag10)
							{
								this.error1.Text = "Ошибка!\nАллели не могут складываться так: \"AA+BB\"";
								CS$<>8__locals1.er = true;
							}
						}
					}
					bool flag11 = !CS$<>8__locals1.er;
					if (flag11)
					{
						for (int n = 0; n < CS$<>8__locals1.woman.Length; n++)
						{
							for (int a3 = 0; a3 < CS$<>8__locals1.man.Length; a3++)
							{
								bool flag12 = char.IsUpper(CS$<>8__locals1.woms[n]);
								if (flag12)
								{
									child = child + CS$<>8__locals1.woms[n].ToString() + CS$<>8__locals1.mans[a3].ToString() + ";";
								}
								else
								{
									child = child + CS$<>8__locals1.mans[a3].ToString() + CS$<>8__locals1.woms[n].ToString() + ";";
								}
							}
						}
					}
				}
				else
				{
					this.<Button_Click>g__ErrLet|5_2(ref CS$<>8__locals1);
					bool flag13 = !CS$<>8__locals1.er;
					if (flag13)
					{
						char[,] womall = new char[Convert.ToInt32(Math.Pow(2.0, (double)(CS$<>8__locals1.woman.Length / 2))), CS$<>8__locals1.woman.Length / 2];
						char[,] manall = new char[Convert.ToInt32(Math.Pow(2.0, (double)(CS$<>8__locals1.man.Length / 2))), CS$<>8__locals1.woman.Length / 2];
						char[,] childall = new char[Convert.ToInt32(Math.Pow(2.0, (double)(CS$<>8__locals1.woman.Length / 2))) * Convert.ToInt32(Math.Pow(2.0, (double)(CS$<>8__locals1.man.Length / 2))), CS$<>8__locals1.woman.Length + 1];
						MainWindow.<Button_Click>g__Check|5_4(ref womall, CS$<>8__locals1.woman);
						MainWindow.<Button_Click>g__Check|5_4(ref manall, CS$<>8__locals1.man);
						this.f = true;
						this.Penn.Visibility = Visibility.Visible;
						this.<Button_Click>g__foundallforchild|5_3(manall, womall, childall, CS$<>8__locals1.woman, CS$<>8__locals1.man, ref CS$<>8__locals1);
						int i2 = 0;
						while ((double)i2 < Math.Pow((double)CS$<>8__locals1.man.Length, 2.0))
						{
							for (int a4 = 0; a4 < CS$<>8__locals1.woman.Length; a4++)
							{
								child += childall[i2, a4].ToString();
							}
							child += " ";
							i2++;
						}
						this.<Button_Click>g__Penne|5_0(childall, ref CS$<>8__locals1);
					}
				}
				this.childo1.Text = child;
			}
			else
			{
				this.childo1.Text = "Нет аллелей!Пожалуйста,введите аллели родителей";
			}
		}

		private void OpenMain(object sender, RoutedEventArgs e)
		{
			this.scr1.Visibility = Visibility.Collapsed;
			this.womano1.Visibility = Visibility.Collapsed;
			this.mano1.Visibility = Visibility.Collapsed;
			this.childo1.Visibility = Visibility.Collapsed;
			this.error1.Visibility = Visibility.Collapsed;
			this.childlab1.Visibility = Visibility.Collapsed;
			this.manlab1.Visibility = Visibility.Collapsed;
			this.womlab1.Visibility = Visibility.Collapsed;
			this.manicon1.Visibility = Visibility.Collapsed;
			this.womanicon1.Visibility = Visibility.Collapsed;
			this.multipleicon1.Visibility = Visibility.Collapsed;
			this.instr.Visibility = Visibility.Collapsed;
			this.AutorText.Visibility = Visibility.Collapsed;
			this.Main.Visibility = Visibility.Visible;
			this.scr2.Visibility = Visibility.Collapsed;
			this.womano2.Visibility = Visibility.Collapsed;
			this.mano2.Visibility = Visibility.Collapsed;
			this.childo2.Visibility = Visibility.Collapsed;
			this.childo3.Visibility = Visibility.Collapsed;
			this.childo4.Visibility = Visibility.Collapsed;
			this.childo5.Visibility = Visibility.Collapsed;
			this.error2.Visibility = Visibility.Collapsed;
			this.childlab2.Visibility = Visibility.Collapsed;
			this.manlab2.Visibility = Visibility.Collapsed;
			this.womlab2.Visibility = Visibility.Collapsed;
			this.multipleicon2.Visibility = Visibility.Collapsed;
			this.womanicon2.Visibility = Visibility.Collapsed;
			this.manicon2.Visibility = Visibility.Collapsed;
			this.Penn.Visibility = Visibility.Collapsed;
		}

		private void OpenCalc(object sender, RoutedEventArgs e)
		{
			this.scr1.Visibility = Visibility.Visible;
			this.womano1.Visibility = Visibility.Visible;
			this.mano1.Visibility = Visibility.Visible;
			this.childo1.Visibility = Visibility.Visible;
			this.error1.Visibility = Visibility.Visible;
			this.childlab1.Visibility = Visibility.Visible;
			this.manlab1.Visibility = Visibility.Visible;
			this.womlab1.Visibility = Visibility.Visible;
			this.manicon1.Visibility = Visibility.Visible;
			this.womanicon1.Visibility = Visibility.Visible;
			this.multipleicon1.Visibility = Visibility.Visible;
			this.instr.Visibility = Visibility.Collapsed;
			this.AutorText.Visibility = Visibility.Collapsed;
			this.Main.Visibility = Visibility.Collapsed;
			this.scr2.Visibility = Visibility.Collapsed;
			this.womano2.Visibility = Visibility.Collapsed;
			this.mano2.Visibility = Visibility.Collapsed;
			this.childo2.Visibility = Visibility.Collapsed;
			this.childo3.Visibility = Visibility.Collapsed;
			this.childo4.Visibility = Visibility.Collapsed;
			this.childo5.Visibility = Visibility.Collapsed;
			this.error2.Visibility = Visibility.Collapsed;
			this.childlab2.Visibility = Visibility.Collapsed;
			this.manlab2.Visibility = Visibility.Collapsed;
			this.womlab2.Visibility = Visibility.Collapsed;
			this.multipleicon2.Visibility = Visibility.Collapsed;
			this.womanicon2.Visibility = Visibility.Collapsed;
			this.manicon2.Visibility = Visibility.Collapsed;
			bool flag = this.f;
			if (flag)
			{
				this.Penn.Visibility = Visibility.Visible;
			}
			else
			{
				this.Penn.Visibility = Visibility.Collapsed;
			}
		}

		private void OpenCalkMF(object sender, RoutedEventArgs e)
		{
			this.scr1.Visibility = Visibility.Collapsed;
			this.womano1.Visibility = Visibility.Collapsed;
			this.mano1.Visibility = Visibility.Collapsed;
			this.childo1.Visibility = Visibility.Collapsed;
			this.error1.Visibility = Visibility.Collapsed;
			this.childlab1.Visibility = Visibility.Collapsed;
			this.manlab1.Visibility = Visibility.Collapsed;
			this.womlab1.Visibility = Visibility.Collapsed;
			this.manicon1.Visibility = Visibility.Collapsed;
			this.womanicon1.Visibility = Visibility.Collapsed;
			this.multipleicon1.Visibility = Visibility.Collapsed;
			this.instr.Visibility = Visibility.Collapsed;
			this.AutorText.Visibility = Visibility.Collapsed;
			this.Main.Visibility = Visibility.Collapsed;
			this.scr2.Visibility = Visibility.Visible;
			this.womano2.Visibility = Visibility.Visible;
			this.mano2.Visibility = Visibility.Visible;
			this.childo2.Visibility = Visibility.Visible;
			this.childo3.Visibility = Visibility.Visible;
			this.childo4.Visibility = Visibility.Visible;
			this.childo5.Visibility = Visibility.Visible;
			this.error2.Visibility = Visibility.Visible;
			this.childlab2.Visibility = Visibility.Visible;
			this.manlab2.Visibility = Visibility.Visible;
			this.womlab2.Visibility = Visibility.Visible;
			this.multipleicon2.Visibility = Visibility.Visible;
			this.womanicon2.Visibility = Visibility.Visible;
			this.manicon2.Visibility = Visibility.Visible;
			this.Penn.Visibility = Visibility.Collapsed;
		}

		private void OpenInstr(object sender, RoutedEventArgs e)
		{
			this.scr1.Visibility = Visibility.Collapsed;
			this.womano1.Visibility = Visibility.Collapsed;
			this.mano1.Visibility = Visibility.Collapsed;
			this.childo1.Visibility = Visibility.Collapsed;
			this.error1.Visibility = Visibility.Collapsed;
			this.childlab1.Visibility = Visibility.Collapsed;
			this.manlab1.Visibility = Visibility.Collapsed;
			this.womlab1.Visibility = Visibility.Collapsed;
			this.manicon1.Visibility = Visibility.Collapsed;
			this.womanicon1.Visibility = Visibility.Collapsed;
			this.multipleicon1.Visibility = Visibility.Collapsed;
			this.instr.Visibility = Visibility.Visible;
			this.AutorText.Visibility = Visibility.Collapsed;
			this.Main.Visibility = Visibility.Collapsed;
			this.scr2.Visibility = Visibility.Collapsed;
			this.womano2.Visibility = Visibility.Collapsed;
			this.mano2.Visibility = Visibility.Collapsed;
			this.childo2.Visibility = Visibility.Collapsed;
			this.childo3.Visibility = Visibility.Collapsed;
			this.childo4.Visibility = Visibility.Collapsed;
			this.childo5.Visibility = Visibility.Collapsed;
			this.error2.Visibility = Visibility.Collapsed;
			this.childlab2.Visibility = Visibility.Collapsed;
			this.manlab2.Visibility = Visibility.Collapsed;
			this.womlab2.Visibility = Visibility.Collapsed;
			this.multipleicon2.Visibility = Visibility.Collapsed;
			this.womanicon2.Visibility = Visibility.Collapsed;
			this.manicon2.Visibility = Visibility.Collapsed;
			this.Penn.Visibility = Visibility.Collapsed;
		}

		private void OpenAutor(object sender, RoutedEventArgs e)
		{
			this.scr1.Visibility = Visibility.Collapsed;
			this.womano1.Visibility = Visibility.Collapsed;
			this.mano1.Visibility = Visibility.Collapsed;
			this.childo1.Visibility = Visibility.Collapsed;
			this.error1.Visibility = Visibility.Collapsed;
			this.childlab1.Visibility = Visibility.Collapsed;
			this.manlab1.Visibility = Visibility.Collapsed;
			this.womlab1.Visibility = Visibility.Collapsed;
			this.manicon1.Visibility = Visibility.Collapsed;
			this.womanicon1.Visibility = Visibility.Collapsed;
			this.multipleicon1.Visibility = Visibility.Collapsed;
			this.instr.Visibility = Visibility.Collapsed;
			this.AutorText.Visibility = Visibility.Visible;
			this.Main.Visibility = Visibility.Collapsed;
			this.scr2.Visibility = Visibility.Collapsed;
			this.womano2.Visibility = Visibility.Collapsed;
			this.mano2.Visibility = Visibility.Collapsed;
			this.childo2.Visibility = Visibility.Collapsed;
			this.childo3.Visibility = Visibility.Collapsed;
			this.childo4.Visibility = Visibility.Collapsed;
			this.childo5.Visibility = Visibility.Collapsed;
			this.error2.Visibility = Visibility.Collapsed;
			this.childlab2.Visibility = Visibility.Collapsed;
			this.manlab2.Visibility = Visibility.Collapsed;
			this.womlab2.Visibility = Visibility.Collapsed;
			this.multipleicon2.Visibility = Visibility.Collapsed;
			this.womanicon2.Visibility = Visibility.Collapsed;
			this.manicon2.Visibility = Visibility.Collapsed;
			this.Penn.Visibility = Visibility.Collapsed;
		}

		private void scr2_Click(object sender, RoutedEventArgs e)
		{
			string erro = "Ошибка!\nЗапись может иметь максимум 4 символа в длину(Например: X*Y*)";
			string erro2 = "Ошибка!\nЗапись имеет максимум 4 символа в длину(Например: X*Y*)";
			string erro3 = "Ошибка!\nЖенская и мужская пары хромосом начинаются с \"X\",\nженская оканчивается на \"X\", мужская на \"Y\".";
			this.error2.Text = "";
			char[] woman = new char[4];
			char[] man = new char[4];
			string[] charsw = new string[2];
			string[] charsm = new string[2];
			for (int i = 0; i < this.womano2.Text.Length; i++)
			{
				woman[i] = this.womano2.Text[i];
			}
			for (int j = 0; j < this.mano2.Text.Length; j++)
			{
				man[j] = this.mano2.Text[j];
			}
			bool err = false;
			bool flag = this.womano2.Text != "" && this.mano2.Text != "";
			if (flag)
			{
				bool flag2 = this.womano2.Text.Length > 4;
				if (flag2)
				{
					this.error2.Text = erro;
					err = true;
				}
				bool flag3 = this.mano2.Text.Length > 4;
				if (flag3)
				{
					this.error2.Text = erro2;
					err = true;
				}
				bool flag4 = !err;
				if (flag4)
				{
					MainWindow.<scr2_Click>g__CheckForX|11_0(woman, 0);
					MainWindow.<scr2_Click>g__CheckForY|11_1(woman, 0);
					bool flag5 = MainWindow.<scr2_Click>g__CheckForX|11_0(woman, 0) && MainWindow.<scr2_Click>g__CheckForX|11_0(man, 0);
					if (flag5)
					{
						bool flag6 = MainWindow.<scr2_Click>g__CheckForX|11_0(woman, 1);
						if (flag6)
						{
							charsw[0] = (string.Format("{0}", woman[0]) ?? "");
							bool flag7 = woman[2] > '\0';
							if (flag7)
							{
								charsw[1] = ((string.Format("{0}", woman[1]) + string.Format("{0}", woman[2])) ?? "");
							}
							else
							{
								charsw[1] = (string.Format("{0}", woman[1]) ?? "");
							}
						}
						else
						{
							bool flag8 = MainWindow.<scr2_Click>g__CheckForX|11_0(woman, 2);
							if (flag8)
							{
								charsw[0] = ((string.Format("{0}", woman[0]) + string.Format("{0}", woman[1])) ?? "");
								bool flag9 = woman[3] > '\0';
								if (flag9)
								{
									charsw[1] = ((string.Format("{0}", woman[2]) + string.Format("{0}", woman[3])) ?? "");
								}
								else
								{
									charsw[1] = (string.Format("{0}", woman[2]) ?? "");
								}
							}
							else
							{
								this.error2.Text = erro3;
							}
						}
						bool flag10 = MainWindow.<scr2_Click>g__CheckForY|11_1(man, 1);
						if (flag10)
						{
							charsm[0] = (string.Format("{0}", man[0]) ?? "");
							bool flag11 = man[2] > '\0';
							if (flag11)
							{
								charsm[1] = ((string.Format("{0}", man[1]) + string.Format("{0}", man[2])) ?? "");
							}
							else
							{
								charsm[1] = (string.Format("{0}", man[1]) ?? "");
							}
						}
						else
						{
							bool flag12 = MainWindow.<scr2_Click>g__CheckForY|11_1(man, 2);
							if (flag12)
							{
								charsm[0] = ((string.Format("{0}", man[0]) + string.Format("{0}", man[1])) ?? "");
								bool flag13 = man[3] > '\0';
								if (flag13)
								{
									charsm[1] = ((string.Format("{0}", man[2]) + string.Format("{0}", man[3])) ?? "");
								}
								else
								{
									charsm[1] = (string.Format("{0}", man[2]) ?? "");
								}
							}
							else
							{
								this.error2.Text = erro3;
							}
						}
					}
					else
					{
						this.error2.Text = erro3;
					}
					this.childo2.Text = ((charsw[0] + charsm[0]) ?? "");
					this.childo3.Text = ((charsw[0] + charsm[1]) ?? "");
					this.childo4.Text = ((charsw[1] + charsm[0]) ?? "");
					this.childo5.Text = ((charsw[1] + charsm[1]) ?? "");
				}
				else
				{
					this.error2.Text = erro3;
				}
			}
		}

		private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.Close();
		}

		private void Window_MouseDown_1(object sender, MouseButtonEventArgs e)
		{
			bool flag = e.ChangedButton == MouseButton.Middle && e.ButtonState == MouseButtonState.Pressed;
			if (flag)
			{
				base.Close();
			}
		}
		private void Penn_Click_1(object sender, RoutedEventArgs e)
		{
			this.PennetWindow.Visibility = Visibility.Visible;
		}

		private void PennetWindow_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
		{
			this.PennetWindow.Visibility = Visibility.Collapsed;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			bool contentLoaded = this._contentLoaded;
			if (!contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocater = new Uri("/Feature_Inheritance;component/mainwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocater);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((MainWindow)target).MouseLeftButtonDown += this.Window_MouseDown;
				((MainWindow)target).MouseRightButtonUp += this.Window_MouseRightButtonDown;
				((MainWindow)target).MouseDown += this.Window_MouseDown_1;
				break;
			case 2:
				this.MainGrid = (ColumnDefinition)target;
				break;
			case 3:
				this.Gri = (ColumnDefinition)target;
				break;
			case 4:
				this.Penn = (Button)target;
				this.Penn.Click += this.Penn_Click_1;
				break;
			case 5:
				this.multipleicon1 = (TextBlock)target;
				break;
			case 6:
				this.womanicon1 = (TextBlock)target;
				break;
			case 7:
				this.manicon1 = (TextBlock)target;
				break;
			case 8:
				this.scr1 = (Button)target;
				this.scr1.Click += this.Button_Click;
				break;
			case 9:
				this.womano1 = (TextBox)target;
				break;
			case 10:
				this.mano1 = (TextBox)target;
				break;
			case 11:
				this.childo1 = (TextBlock)target;
				break;
			case 12:
				this.error1 = (TextBlock)target;
				break;
			case 13:
				this.childlab1 = (Label)target;
				break;
			case 14:
				this.manlab1 = (Label)target;
				break;
			case 15:
				this.womlab1 = (Label)target;
				break;
			case 16:
				this.instr = (Label)target;
				break;
			case 17:
				this.AutorText = (TextBlock)target;
				break;
			case 18:
				this.scr2 = (Button)target;
				this.scr2.Click += this.scr2_Click;
				break;
			case 19:
				this.womano2 = (TextBox)target;
				break;
			case 20:
				this.mano2 = (TextBox)target;
				break;
			case 21:
				this.childo2 = (TextBlock)target;
				break;
			case 22:
				this.childo3 = (TextBlock)target;
				break;
			case 23:
				this.childo4 = (TextBlock)target;
				break;
			case 24:
				this.childo5 = (TextBlock)target;
				break;
			case 25:
				this.error2 = (TextBlock)target;
				break;
			case 26:
				this.childlab2 = (Label)target;
				break;
			case 27:
				this.manlab2 = (Label)target;
				break;
			case 28:
				this.womlab2 = (Label)target;
				break;
			case 29:
				this.multipleicon2 = (TextBlock)target;
				break;
			case 30:
				this.womanicon2 = (TextBlock)target;
				break;
			case 31:
				this.manicon2 = (TextBlock)target;
				break;
			case 32:
				this.Main = (ScrollViewer)target;
				break;
			case 33:
				this.PennetWindow = (StackPanel)target;
				this.PennetWindow.MouseRightButtonUp += this.PennetWindow_MouseRightButtonUp;
				break;
			case 34:
				((ListViewItem)target).MouseLeftButtonUp += this.PennetWindow_MouseRightButtonUp;
				break;
			case 35:
				this.TableOfPennet = (StackPanel)target;
				break;
			case 36:
				this.GridMenu = (Grid)target;
				break;
			case 37:
				this.MenuGrid = (StackPanel)target;
				break;
			case 38:
				((ListViewItem)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.OpenMain);
				break;
			case 39:
				((ListViewItem)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.OpenCalc);
				break;
			case 40:
				((ListViewItem)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.OpenCalkMF);
				break;
			case 41:
				((ListViewItem)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.OpenInstr);
				break;
			case 42:
				((ListViewItem)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.OpenAutor);
				break;
			case 43:
				this.Hello = (TextBlock)target;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		[CompilerGenerated]
		private void <Button_Click>g__foundallforchild|5_3(char[,] mana, char[,] woma, char[,] childa, string womanf, string manf, ref MainWindow.<>c__DisplayClass5_0 A_6)
		{
			int i = 0;
			for (int j = 0; j < Convert.ToInt32(Math.Pow(2.0, (double)(manf.Length / 2))); j++)
			{
				for (int w = 0; w < Convert.ToInt32(Math.Pow(2.0, (double)(womanf.Length / 2))); w++)
				{
					int f = 0;
					bool flag = i >= Convert.ToInt32(Math.Pow(2.0, (double)(womanf.Length / 2))) * Convert.ToInt32(Math.Pow(2.0, (double)(A_6.man.Length / 2)));
					if (flag)
					{
						break;
					}
					for (int g = 0; g < womanf.Length / 2; g++)
					{
						bool flag2 = char.IsUpper(mana[j, g]);
						if (flag2)
						{
							childa[i, f] = mana[j, g];
							f++;
							childa[i, f] = woma[w, g];
							f++;
						}
						else
						{
							childa[i, f] = woma[w, g];
							f++;
							childa[i, f] = mana[j, g];
							f++;
						}
					}
					i++;
				}
				bool flag3 = i >= Convert.ToInt32(Math.Pow(2.0, (double)(womanf.Length / 2))) * Convert.ToInt32(Math.Pow(2.0, (double)(manf.Length / 2)));
				if (flag3)
				{
					break;
				}
			}
		}

		[CompilerGenerated]
		internal static void <Button_Click>g__Check|5_4(ref char[,] comb, string womanf)
		{
			MainWindow.<>c__DisplayClass5_1 CS$<>8__locals1;
			CS$<>8__locals1.womanf = womanf;
			MainWindow.<Button_Click>g__str|5_5(ref comb, ref CS$<>8__locals1);
		}

		[CompilerGenerated]
		internal static void <Button_Click>g__str|5_5(ref char[,] comb1, ref MainWindow.<>c__DisplayClass5_1 A_1)
		{
			int nu = 0;
			string i = A_1.womanf;
			int j = i.Length / 2;
			int[] a = new int[j];
			int[,] combos = new int[Convert.ToInt32(Math.Pow(2.0, (double)j)), j];
			bool flag = i.Length - 1 >= j;
			if (flag)
			{
				while (MainWindow.<Button_Click>g__NextSet|5_6(a, i.Length - 1, j))
				{
					int t = 0;
					for (int k = 0; k < j; k++)
					{
						bool flag2 = a[k] != k * 2 && a[k] != k * 2 + 1;
						if (flag2)
						{
							t++;
						}
					}
					bool flag3 = t == 0;
					if (flag3)
					{
						bool flag4 = a[1] != 0;
						if (flag4)
						{
							for (int l = 0; l < j; l++)
							{
								combos[nu, l] = a[l];
							}
							nu++;
						}
					}
				}
			}
			int m = 0;
			while ((double)m < Math.Pow(2.0, (double)j))
			{
				for (int f = 0; f < j; f++)
				{
					ref char ptr = ref comb1[m, f];
					ptr += i[combos[m, f]];
				}
				m++;
			}
		}

		[CompilerGenerated]
		internal static bool <Button_Click>g__NextSet|5_6(int[] a, int n, int m)
		{
			for (int i = m - 1; i >= 0; i--)
			{
				bool flag = a[i] < n - m + i + 1;
				if (flag)
				{
					a[i]++;
					for (int j = i + 1; j < m; j++)
					{
						a[j] = a[j - 1] + 1;
					}
					return true;
				}
			}
			return false;
		}

		[CompilerGenerated]
		private void <Button_Click>g__Penne|5_0(char[,] childall, ref MainWindow.<>c__DisplayClass5_0 A_2)
		{
			while (this.TableOfPennet.Children.Count > 0)
			{
				this.TableOfPennet.Children.RemoveAt(this.TableOfPennet.Children.Count - 1);
			}
			int qw = 0;
			double maxwidth = (double)(A_2.man.Length * 16);
			for (int i = 0; i < A_2.woman.Length; i++)
			{
				StackPanel StringOfPennet = new StackPanel();
				StringOfPennet.Orientation = Orientation.Horizontal;
				this.TableOfPennet.Children.Add(StringOfPennet);
				for (int f = 0; f < A_2.woman.Length; f++)
				{
					TextBlock ch = new TextBlock();
					ch.Background = Brushes.Azure;
					ch.Width = maxwidth;
					for (int g = 0; g < A_2.woman.Length; g++)
					{
						TextBlock textBlock = ch;
						textBlock.Text += childall[qw, g].ToString();
					}
					TextBlock textBlock2 = ch;
					textBlock2.Text += ";";
					qw++;
					StringOfPennet.Children.Add(ch);
				}
			}
		}

		[CompilerGenerated]
		private void <Button_Click>g__ErrorChek|5_1(ref MainWindow.<>c__DisplayClass5_0 A_1)
		{
			bool aAch = false;
			bool flag = A_1.mans.Length != A_1.woms.Length;
			if (flag)
			{
				TextBlock textBlock = this.error1;
				textBlock.Text += "Ошибка!\nКоличество аллелей не может быть разным!";
				A_1.er = true;
			}
			else
			{
				bool flag2 = (A_1.woms.Length % 2 == 1 && !A_1.er) || (A_1.mans.Length % 2 == 1 && !A_1.er);
				if (flag2)
				{
					A_1.er = true;
					TextBlock textBlock2 = this.error1;
					textBlock2.Text += "\nОшибка!\nКоличество аллелей может быть кратным только двум!";
				}
				else
				{
					bool flag3 = !A_1.er;
					if (flag3)
					{
						for (int i = 0; i < A_1.woms.Length; i += 2)
						{
							bool flag4 = char.IsLower(A_1.woms[i]) && char.IsUpper(A_1.woms[i + 1]);
							if (flag4)
							{
								TextBlock textBlock3 = this.error1;
								textBlock3.Text += "\nОшибка!\nТакой способ ввода недопустим!\nАллели не могут иметь вид \"аА\"";
								A_1.er = true;
							}
						}
					}
					else
					{
						bool flag5 = !A_1.er;
						if (flag5)
						{
							for (int j = 0; j < A_1.mans.Length; j += 2)
							{
								bool flag6 = char.IsLower(A_1.man[j]) && char.IsUpper(A_1.man[j + 1]) && !aAch;
								if (flag6)
								{
									TextBlock textBlock4 = this.error1;
									textBlock4.Text += "\nОшибка!\nТакой способ ввода недопустим!\nАллели не могут иметь вид \"аА\"";
									aAch = true;
									A_1.er = true;
								}
							}
						}
					}
				}
			}
		}

		[CompilerGenerated]
		private void <Button_Click>g__ErrLet|5_2(ref MainWindow.<>c__DisplayClass5_0 A_1)
		{
			bool flag = !A_1.er;
			if (flag)
			{
				for (int i = 0; i < A_1.smman.Length; i++)
				{
					bool flag2 = A_1.smman[i] != A_1.smwom[i];
					if (flag2)
					{
						this.error1.Text = "Ошибка!\nНе существует скрещивания вида \"Aa + Bb\"";
						A_1.er = true;
						break;
					}
				}
			}
			bool flag3 = !A_1.er;
			if (flag3)
			{
				for (int j = 0; j < A_1.smman.Length; j += 2)
				{
					for (int a = 2; a < A_1.smman.Length - j; a += 2)
					{
						bool flag4 = A_1.smman[j + a] <= A_1.smman[A_1.smman.Length - 1];
						if (flag4)
						{
							bool flag5 = A_1.smman[j] == A_1.smman[j + a];
							if (flag5)
							{
								this.error1.Text = "Ошибка!\nНевозможен вид записи \"AaAa\"!";
								A_1.er = true;
							}
						}
					}
				}
			}
			bool flag6 = !A_1.er;
			if (flag6)
			{
				for (int k = 0; k < A_1.smwom.Length; k += 2)
				{
					for (int a2 = 2; a2 < A_1.smwom.Length - k; a2 += 2)
					{
						bool flag7 = A_1.smwom[k + a2] <= A_1.smwom[A_1.smwom.Length - 1];
						if (flag7)
						{
							bool flag8 = A_1.smwom[k] == A_1.smwom[k + a2];
							if (flag8)
							{
								this.error1.Text = "Ошибка!\nНевозможен вид записи \"AaAa\"!";
								A_1.er = true;
							}
						}
					}
				}
			}
		}

		[CompilerGenerated]
		internal static bool <scr2_Click>g__CheckForX|11_0(char[] smb, int t)
		{
			return smb[t] == 'x' || smb[t] == 'X' || smb[t] == 'х' || smb[t] == 'Х';
		}

		[CompilerGenerated]
		internal static bool <scr2_Click>g__CheckForY|11_1(char[] ma, int t)
		{
			return ma[t] == 'Y' || ma[t] == 'y' || ma[t] == 'У' || ma[t] == 'у';
		}

		private bool f = false;

		internal ColumnDefinition MainGrid;
		internal ColumnDefinition Gri;
		internal Button Penn;
		internal TextBlock multipleicon1;
		internal TextBlock womanicon1;
		internal TextBlock manicon1;
		internal Button scr1;
		internal TextBox womano1;
		internal TextBox mano1;
		internal TextBlock childo1;
		internal TextBlock error1;
		internal Label childlab1;
		internal Label manlab1;
		internal Label womlab1;
		internal Label instr;
		internal TextBlock AutorText;
		internal Button scr2;
		internal TextBox womano2;
		internal TextBox mano2;
		internal TextBlock childo2;
		internal TextBlock childo3;
		internal TextBlock childo4;
		internal TextBlock childo5;
		internal TextBlock error2;
		internal Label childlab2;
		internal Label manlab2;
		internal Label womlab2;
		internal TextBlock multipleicon2;
		internal TextBlock womanicon2;
		internal TextBlock manicon2;
		internal ScrollViewer Main;
		internal StackPanel PennetWindow;
		internal StackPanel TableOfPennet;
		internal Grid GridMenu;
		internal StackPanel MenuGrid;
		internal TextBlock Hello;
		private bool _contentLoaded;
	}
}
