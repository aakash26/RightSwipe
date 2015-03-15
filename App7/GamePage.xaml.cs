using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;
 
using Windows.UI.Xaml.Media.Animation;
using Windows.Phone.UI.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        
        
        Storyboard wrong2,right2;
        int x1, x2, x3;
        int y1, y2, y3;
        int[] idx,cidx;
        Storyboard [] arr = new Storyboard[112];
        int ctr=0;
       
    
        
        private int checkbetween(int x)
        {
            if (x <= 31)
                return 0;
            else if (x >= 32 && x <= 55)
                return 1;
            else if (x >= 56 && x <= 87)
                return 2;
            else
                return 3;
        }
        async void DelayMethod()
        {
            TimeSpan time = TimeSpan.FromMilliseconds(20000);
            await System.Threading.Tasks.Task.Delay(time);//halts execution for 1000 milliseconds
        }
        private static int RandomNumber(int i,int j)
        {
            Random random = new Random();        
            return random.Next(i, j);
        }
        private int randnum()
        {
            Random num = new Random();
            return num.Next(0, 111);
        }
     
        private int torf(int num,int swipe)
        {
            int where = checkbetween(num);
            int fidx, lidx;
            if (where == 0)
            {
                fidx = num / 4;
                lidx = idx[fidx] + 3;
            }
            else if (where == 1)
            {
                fidx = (num - 32) / 3 + 8;
                lidx = idx[fidx] + 2;
            }
            else if (where == 2)
            {
                fidx = (num - 56) / 4 + 16;
                lidx = idx[fidx] + 3;
            }
            else
            {
                fidx = (num - 88) / 3 + 24;
                lidx = idx[fidx] + 2;
            }
            if (swipe == cidx[fidx])
                return 1;
            else
                return 0;
            //fidx = idx[fidx];
        }
        private void func()
        {
           arr[0].Completed += (o, s) =>
            {
                arr[0].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[0].Begin();
            };
            arr[1].Completed += (o, s) =>
            {
                arr[1].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[1].Begin();
            };
            arr[2].Completed += (o, s) =>
            {
                arr[2].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[2].Begin();
            };
            arr[3].Completed += (o, s) =>
            {
                arr[3].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[3].Begin();
            };
            arr[4].Completed += (o, s) =>
            {
                arr[4].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[4].Begin();
            };
            arr[5].Completed += (o, s) =>
            {
                arr[5].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[5].Begin();
            };
            arr[6].Completed += (o, s) =>
            {
                arr[6].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[6].Begin();
            };
            arr[7].Completed += (o, s) =>
            {
                arr[7].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[7].Begin();
            };
            arr[8].Completed += (o, s) =>
            {
                arr[8].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[8].Begin();
            };
            arr[9].Completed += (o, s) =>
            {
                arr[9].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[9].Begin();
            };
            arr[10].Completed += (o, s) =>
            {
                arr[10].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[10].Begin();
            };
            arr[11].Completed += (o, s) =>
            {
                arr[11].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[11].Begin();
            };
            arr[12].Completed += (o, s) =>
            {
                arr[12].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[12].Begin();
            };
            arr[13].Completed += (o, s) =>
            {
                arr[13].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[13].Begin();
            };
            arr[14].Completed += (o, s) =>
            {
                arr[14].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[14].Begin();
            };
            arr[15].Completed += (o, s) =>
            {
                arr[15].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[15].Begin();
            };
            arr[16].Completed += (o, s) =>
            {
                arr[16].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[16].Begin();
            };
            arr[17].Completed += (o, s) =>
            {
                arr[17].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[17].Begin();
            };
            arr[18].Completed += (o, s) =>
            {
                arr[18].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[18].Begin();
            };
            arr[19].Completed += (o, s) =>
            {
                arr[19].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[19].Begin();
            };
            arr[20].Completed += (o, s) =>
            {
                arr[20].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[20].Begin();
            };
            arr[21].Completed += (o, s) =>
            {
                arr[21].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[21].Begin();
            };
            arr[22].Completed += (o, s) =>
            {
                arr[22].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[22].Begin();
            };
            arr[23].Completed += (o, s) =>
            {
                arr[23].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[23].Begin();
            };
            arr[24].Completed += (o, s) =>
            {
                arr[24].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[24].Begin();
            };
            arr[25].Completed += (o, s) =>
            {
                arr[25].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[25].Begin();
            };
            arr[26].Completed += (o, s) =>
            {
                arr[26].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[26].Begin();
            };
            arr[27].Completed += (o, s) =>
            {
                arr[27].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[27].Begin();
            };
            arr[28].Completed += (o, s) =>
            {
                arr[28].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[28].Begin();
            };
            arr[29].Completed += (o, s) =>
            {
                arr[29].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[29].Begin();
            };
            arr[30].Completed += (o, s) =>
            {
                arr[30].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[30].Begin();
            };
            arr[31].Completed += (o, s) =>
            {
                arr[31].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[31].Begin();
            };
            arr[32].Completed += (o, s) =>
            {
                arr[32].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[32].Begin();
            };
            arr[33].Completed += (o, s) =>
            {
                arr[33].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[33].Begin();
            };
            arr[34].Completed += (o, s) =>
            {
                arr[34].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[34].Begin();
            };
            arr[35].Completed += (o, s) =>
            {
                arr[35].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[35].Begin();
            };
            arr[36].Completed += (o, s) =>
            {
                arr[36].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[36].Begin();
            };
            arr[37].Completed += (o, s) =>
            {
                arr[37].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[37].Begin();
            };
            arr[38].Completed += (o, s) =>
            {
                arr[38].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[38].Begin();
            };
            arr[39].Completed += (o, s) =>
            {
                arr[39].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[39].Begin();
            };
            arr[40].Completed += (o, s) =>
            {
                arr[40].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[40].Begin();
            };
            arr[41].Completed += (o, s) =>
            {
                arr[41].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[41].Begin();
            };
            arr[42].Completed += (o, s) =>
            {
                arr[42].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[42].Begin();
            };
            arr[43].Completed += (o, s) =>
            {
                arr[43].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[43].Begin();
            };
            arr[44].Completed += (o, s) =>
            {
                arr[44].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[44].Begin();
            };
            arr[45].Completed += (o, s) =>
            {
                arr[45].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[45].Begin();
            };
            arr[46].Completed += (o, s) =>
            {
                arr[46].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[46].Begin();
            };
            arr[47].Completed += (o, s) =>
            {
                arr[47].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[47].Begin();
            };
            arr[48].Completed += (o, s) =>
            {
                arr[48].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[48].Begin();
            };
            arr[49].Completed += (o, s) =>
            {
                arr[49].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[49].Begin();
            };
            arr[50].Completed += (o, s) =>
            {
                arr[50].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[50].Begin();
            };
            arr[51].Completed += (o, s) =>
            {
                arr[51].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[51].Begin();
            };
            arr[52].Completed += (o, s) =>
            {
                arr[52].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[52].Begin();
            };
            arr[53].Completed += (o, s) =>
            {
                arr[53].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[53].Begin();
            };
            arr[54].Completed += (o, s) =>
            {
                arr[54].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[54].Begin();
            };
            arr[55].Completed += (o, s) =>
            {
                arr[55].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[55].Begin();
            };
            arr[56].Completed += (o, s) =>
            {
                arr[56].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[56].Begin();
            };
            arr[57].Completed += (o, s) =>
            {
                arr[57].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[57].Begin();
            };
            arr[58].Completed += (o, s) =>
            {
                arr[58].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[58].Begin();
            };
            arr[59].Completed += (o, s) =>
            {
                arr[59].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[59].Begin();
            };
            arr[60].Completed += (o, s) =>
            {
                arr[60].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[60].Begin();
            };
            arr[61].Completed += (o, s) =>
            {
                arr[61].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[61].Begin();
            };
            arr[62].Completed += (o, s) =>
            {
                arr[62].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[62].Begin();
            };
            arr[63].Completed += (o, s) =>
            {
                arr[63].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[63].Begin();
            };
            arr[64].Completed += (o, s) =>
            {
                arr[64].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[64].Begin();
            };
            arr[65].Completed += (o, s) =>
            {
                arr[65].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[65].Begin();
            };
            arr[66].Completed += (o, s) =>
            {
                arr[66].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[66].Begin();
            };
            arr[67].Completed += (o, s) =>
            {
                arr[67].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[67].Begin();
            };
            arr[68].Completed += (o, s) =>
            {
                arr[68].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[68].Begin();
            };
            arr[69].Completed += (o, s) =>
            {
                arr[69].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[69].Begin();
            };
            arr[70].Completed += (o, s) =>
            {
                arr[70].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[70].Begin();
            };
            arr[71].Completed += (o, s) =>
            {
                arr[71].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[71].Begin();
            };
            arr[72].Completed += (o, s) =>
            {
                arr[72].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[72].Begin();
            };
            arr[73].Completed += (o, s) =>
            {
                arr[73].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[73].Begin();
            };
            arr[74].Completed += (o, s) =>
            {
                arr[74].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[74].Begin();
            };
            arr[75].Completed += (o, s) =>
            {
                arr[75].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[75].Begin();
            };
            arr[76].Completed += (o, s) =>
            {
                arr[76].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[76].Begin();
            };
            arr[77].Completed += (o, s) =>
            {
                arr[77].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[77].Begin();
            };
            arr[78].Completed += (o, s) =>
            {
                arr[78].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[78].Begin();
            };
            arr[79].Completed += (o, s) =>
            {
                arr[79].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[79].Begin();
            };
            arr[80].Completed += (o, s) =>
            {
                arr[80].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[80].Begin();
            };
            arr[81].Completed += (o, s) =>
            {
                arr[81].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[81].Begin();
            };
            arr[82].Completed += (o, s) =>
            {
                arr[82].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[82].Begin();
            };
            arr[83].Completed += (o, s) =>
            {
                arr[83].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[83].Begin();
            };
            arr[84].Completed += (o, s) =>
            {
                arr[84].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[84].Begin();
            };
            arr[85].Completed += (o, s) =>
            {
                arr[85].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[85].Begin();
            };
            arr[86].Completed += (o, s) =>
            {
                arr[86].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[86].Begin();
            };
            arr[87].Completed += (o, s) =>
            {
                arr[87].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[87].Begin();
            };
            arr[88].Completed += (o, s) =>
            {
                arr[88].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[88].Begin();
            };
            arr[89].Completed += (o, s) =>
            {
                arr[89].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[89].Begin();
            };
            arr[90].Completed += (o, s) =>
            {
                arr[90].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[90].Begin();
            };
            arr[91].Completed += (o, s) =>
            {
                arr[91].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[91].Begin();
            };
            arr[92].Completed += (o, s) =>
            {
                arr[92].BeginTime = TimeSpan.FromSeconds(RandomNumber(0, 0));
                arr[92].Begin();
            };
            arr[93].Completed += (o, s) =>
            {
                arr[93].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[93].Begin();
            };
            arr[94].Completed += (o, s) =>
            {
                arr[94].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[94].Begin();
            };
            arr[95].Completed += (o, s) =>
            {
                arr[95].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[95].Begin();
            };
            arr[96].Completed += (o, s) =>
            {
                arr[96].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[96].Begin();
            };
            arr[97].Completed += (o, s) =>
            {
                arr[97].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[97].Begin();
            };
            arr[98].Completed += (o, s) =>
            {
                arr[98].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[98].Begin();
            };
            arr[99].Completed += (o, s) =>
            {
                arr[99].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[99].Begin();
            };
            arr[100].Completed += (o, s) =>
            {
                arr[100].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[100].Begin();
            };
            arr[101].Completed += (o, s) =>
            {
                arr[101].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[101].Begin();
            };
            arr[102].Completed += (o, s) =>
            {
                arr[102].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[102].Begin();
            };
            arr[103].Completed += (o, s) =>
            {
                arr[103].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[103].Begin();
            };
            arr[104].Completed += (o, s) =>
            {
                arr[104].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[104].Begin();
            };
            arr[105].Completed += (o, s) =>
            {
                arr[105].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
                arr[105].Begin();
            };
            arr[106].Completed += (o, s) =>
            {
                arr[106].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[106].Begin();
            };
            arr[107].Completed += (o, s) =>
            {
                arr[107].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[107].Begin();
            };
            arr[108].Completed += (o, s) =>
            {
                arr[108].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
                arr[108].Begin();
            };
            arr[109].Completed += (o, s) =>
            {
                arr[109].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
                arr[109].Begin();
            };
            arr[110].Completed += (o, s) =>
            {
                arr[110].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
                arr[110].Begin();
            };
            arr[111].Completed += (o, s) =>
            {
                arr[111].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
                arr[111].Begin();
            };
        }
        void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
            {
                return;
            }

            if (frame.CanGoBack)
            {
                frame.GoBack();
                //Indicate the back button press is handled so the app does not exit  
                e.Handled = true;
            }
        }  
        public GamePage()

        {
        
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            
            this.NavigationCacheMode = NavigationCacheMode.Required;
          
            bobo.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            bobo.ManipulationStarted += (s, e) => x1 = (int)e.Position.X;
            bobo.ManipulationStarted += (s, e) => y1 = (int)e.Position.Y;
            Random num = new Random();
            arr = new Storyboard[112];
            for (int i=0;i<112;i++)
            {
                String t = "Storyboard"+(i+1);
                arr[i] = (Storyboard)Resources[t];
                
            }
            //for (int i1 = 0; i1 < 111; i1++ )
            //{
            func();
            score.Text = "SCORE : " + ctr;
            //}
          
            for (int i = 0; i < 112; i++)
            {
                arr[i].SpeedRatio = 6;
            }
            
           arr[0].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[0].Begin();
            arr[1].BeginTime = TimeSpan.FromSeconds(RandomNumber(0, 0));
            arr[1].Begin();
            arr[2].BeginTime = TimeSpan.FromSeconds(RandomNumber(2, 2));
            arr[2].Begin();
            arr[3].BeginTime = TimeSpan.FromSeconds(RandomNumber(3, 3));
            arr[3].Begin();
            arr[4].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[5].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[6].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[7].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[8].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[9].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[10].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[11].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[12].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[13].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[14].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[15].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[16].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[17].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[18].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[19].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[20].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[21].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[22].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[23].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[24].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[25].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[26].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[27].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[28].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[29].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[30].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[31].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[32].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[33].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[34].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[35].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[36].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[37].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[38].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[39].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[40].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[41].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[42].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[43].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[44].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));    
            arr[45].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[46].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[47].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[48].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[49].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[50].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[51].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[52].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[53].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[54].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[55].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[56].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[57].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[58].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[59].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[60].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[61].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[62].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[63].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[64].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[65].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[66].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[67].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[68].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[69].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[70].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[71].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[72].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[73].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[74].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[75].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[76].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[77].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[78].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[79].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[80].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[81].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[82].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[83].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[84].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[85].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[86].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[87].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[88].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[89].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[90].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[91].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[92].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[93].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[94].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[95].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[96].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[97].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[98].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[99].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[100].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[101].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[102].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[103].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[104].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[105].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[106].BeginTime = TimeSpan.FromSeconds(RandomNumber(2,2));
            arr[107].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
            arr[108].BeginTime = TimeSpan.FromSeconds(RandomNumber(1,1));
            arr[109].BeginTime = TimeSpan.FromSeconds(RandomNumber(4,4));
            arr[110].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,0));
            arr[111].BeginTime = TimeSpan.FromSeconds(RandomNumber(3,3));
          
            for (int i = 4; i < 4;i++ )
            {
                arr[i].BeginTime = TimeSpan.FromSeconds(RandomNumber(0,4));
                arr[i].Begin();
            }
            idx = new int[112];
            int k = 0;
            for (int i = 0; i <= 28; i = i + 4)
                idx[k++] = i;
            for (int i = 32; i <= 53; i = i + 3)
                idx[k++] = i;
            int temp = k;
            for (int i = 0; i <= temp; i++)
                idx[k++] = idx[i] + 56;
            int lastswipe=0;
            int dir = 1;
            wrong2 = (Storyboard)Resources["wrong1"];
            right2 = (Storyboard)Resources["right1"];
            cidx = new int[] { 2, 0, 1, 3, 2, 0, 1, 3, 2, 0, 1, 3, 2, 0, 1, 3 , 0, 0, 1, 1, 1, 1, 0, 0, 2, 2, 3, 3, 3, 3, 2, 2 };
            bobo.ManipulationCompleted += (s, e) =>
            {
                x2 = (int)e.Position.X;
                y2 = (int)e.Position.Y;
                x3 = x1 - x2;
                y3 = y1 - y2;
                x3 = Math.Abs(x3);
                y3 = Math.Abs(y3);

                if (x3 > 100 && y3 < 100)
                {
                    if (x1 > x2)
                    {
                        dir = 1;
                     //   right.Opacity = 0;
                      //  wrong2.Begin();
                       // wrong.Opacity = 100;


                       
                    }
                    if (x1 < x2)
                    {

                        dir = 0;
                        //wrong.Opacity = 0;
                       // right2.Begin();
                        //right.Opacity = 100;
                        //ctr++;
                        

                    }
                }
                else if (x3 < 100 && y3 > 100)
                {
                    if (y1 > y2)
                    {
                        //wrong.Opacity = 0;
                        //right2.Begin();
                        //right.Opacity = 100;
                        //ctr++;
                        dir = 2;

                        
                    }
                    if (y1 < y2)
                    {
                        //right.Opacity = 0;
                        //wrong2.Begin();
                        //wrong.Opacity = 100;
                        dir = 3;
                        
                    }
                }
                
                int sum= torf(lastswipe, dir);
                if (sum == 1)
                {
                    wrong.Opacity = 0;
                    right2.Begin();
                    right.Opacity = 100;
                    right2.Completed += (o, s1) =>
                    {
                        right.Opacity = 0;
                        right2.Stop();
                    };
                    //DelayMethod();
                    //right.Opacity = 0;
                    for (int i = 0; i < 112; i++)
                    {
                        if (ctr > 10)
                        {
                            arr[i].SpeedRatio = 9;
                        }
                        if (ctr > 15)
                            arr[i].SpeedRatio = 20;
                    }
                }
                else
                {
                    right.Opacity = 0;
                    wrong2.Begin();

                    wrong.Opacity = 100;
                    wrong2.Completed += (o, s1) =>
                    {
                        wrong.Opacity = 0;
                        wrong2.Stop();
                    };
                    //DelayMethod();
                    for (int i = 0; i < 112; i++)
                    {
                        if (ctr > 10)
                        {
                            arr[i].SpeedRatio = 9;
                        }
                        if (ctr > 15)
                            arr[i].SpeedRatio = 20;
                    }
                    //wrong.Opacity = 0;
                }
                

                int where = checkbetween(lastswipe);
                int fidx, lidx;
                if (where == 0)
                {
                    fidx = lastswipe / 4;
                    lidx = idx[fidx] + 3;
                }
                else if (where == 1)
                {
                    fidx = (lastswipe - 32) / 3 + 8;
                    lidx = idx[fidx] + 2;
                }
                else if (where == 2)
                {
                    fidx = (lastswipe - 56) / 4 + 16;
                    lidx = idx[fidx] + 3;
                }
                else
                {
                    fidx = (lastswipe - 88) / 3 + 24;
                    lidx = idx[fidx] + 2;
                }
                fidx = idx[fidx];

                for (int i = fidx; i <= lidx;i++ )
                {
                    arr[i].Stop();
                }

                lastswipe = randnum();
                where = checkbetween(lastswipe);
                if (where == 0)
                {
                    fidx = lastswipe / 4;
                    lidx = idx[fidx] + 3;
                }
                else if (where == 1)
                {
                    fidx = (lastswipe - 32) / 3 + 8;
                    lidx = idx[fidx] + 2;
                }
                else if (where == 2)
                {
                    fidx = (lastswipe - 56) / 4 + 16;
                    lidx = idx[fidx] + 3;
                }
                else
                {
                    fidx = (lastswipe - 88) / 3 + 24;
                    lidx = idx[fidx] + 2;
                }
                fidx = idx[fidx];
                for (int i = fidx; i <= lidx; i++)
                {
                    arr[i].Begin();
                }
                    ctr = ctr + sum;
                score.Text = "SCORE : " + ctr;

                wrong2.Stop();
                right2.Stop();  
            };
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

       
    }
}
