using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using C__2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Basic01
{
    internal class Program
    {
        //Entry Point
        static void Main()
        {
            #region Revision

            //Console.WriteLine(value: "Hello World");
            //Console.WriteLine(value: "Hello World");
            //Console.WriteLine(value: "Hello World");

            #endregion

            #region Variable Declaration

            ////Variable Declaration
            ////DataType Varable Name;

            ////int Number; //Declar Variable 
            ////Allocate UnInitialized 4 Bytes At Memory 

            ////Console.WriteLine(Number); //Invalid 
            ////Number = 5;

            ////Variable 

            //    //1.Name        : Number
            //    //2. DateType   : Int
            //    //3.Value       : 5
            //    //4.Size        : 4 Bytes
            //    //5.Address     : 0xF2A

            ////Console.WriteLine(Number); //5 

            ////int number = 5; //Declar And Initialization For The Number
            ////Console.WriteLine(Number);

            ////int Numder01;
            ////int Numder02;
            ////int Numder03;

            ////int Numder01 = 2 , Number02 = 3 , Number03 = 5 ;
            ////Console.WriteLine(Numder01); //2
            ////Numder01 = 7; 
            ////Console.WriteLine(Numder01); //7
            ////Console.WriteLine(Number02); //3
            ////Console.WriteLine(Number03); //5 

            #endregion

            #region CTS And CLS

            //// CTS ==> Common Type System
            //// CLS ==> Common Language Specifications 

            // Data Type

            //1. Value DataType

            //2. Reference DataType  

            #endregion

            #region Memory

            //Memory (RAM)

            //1. Stack
            //1.1. Value Type 
            //1.2. Fixed Size
            //1.3. Size Smaller Than Heap

            //2.Heap
            //2.1. Reference Type 
            //2.2. Dynamic Size
            //1.3. Size Greater Than Stack


            #endregion

            #region DataType

            //1. Value Datatype ( User-Defined Datatype , Built-in Datatype )

            //1.1. Struct 
            //1.2. Enum

            //2. Reference DataType

            //2.1. Class
            //2.2. Interface

            //Built-in Datatype( Value Type ) - Struct
            // Byte    1  Byte
            // Short   2  Bytes
            // Int     4  Bytes
            // Long    8  Bytes

            // Float   4  Bytes
            // Double  8  Bytes
            // Decimal 16 Bytes

            // Ball  True - False

            // Char 'A' , '1' , '#' 2 Byte

            // DataTime 16 Byte

            #endregion

            #region Datatype [Value Type]

            //Int Number;==> Alocate Uninitialized 4 Bytes At Stack 
            //           ==> C# Key Word 
            //           ==> Int32
            // Int32 X=5;==> Alocate Uninitialized 4 Bytes At Stack 
            // Number = X ; // 5

            #endregion

            #region Datatype[Reference Type]

            //Reference Type 

            //Class Point
            //    {

            //        int X;
            //        int Y;

            //    }

            // Point P01 ==> // Declare Reference ( Pointer ) From Type 'Point'

            // P01        : Can Refer To Object From 'Point'

            // Number Of Bytes Will Be Allcated For The Reference At Stack ==> 8 Bytes

            // Number Of Bytes Will Be Allcated For The Reference At HEAP ==> 0 Byte

            // P01 = New Point();

            //New
            //1.Allocate The Required Number Of Byte For The Object At Heap (8+)
            //2.Initialized The Allocated Bytes At HEAP With The Default Value Of The Datatype
            //3.Call User_Defined Constructor If Exists
            //4.Assign The Object To The Reference 'P01'
            //Point P02 = New Point ();

            #endregion

            #region Datatype (Value Type) : Stake

            //Datatype (Value Type) : Stake
            //Declar Variable
            //int Number; //Value Type
            //Alocate Uninitialized 4 Bytes At Stack
            //int : C# Key Word

            //BCL : Int32
            //Int32 Number02;

            //Number = 12;
            //Console.WriteLine(Number);

            //Console.WriteLine(Number02); --Erorr

            #endregion

            #region Datatype[Reference Type] : Heap

            //Point02 p02;//Null
            //p02 = new Point02();
            //Console.WriteLine(p02);//C__2.Point02

            // Declare Reference From Type 'Point'
            // P01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will Be Allcated At Stack For The 'P01' 
            // 0 Bytes Will Be Allcated At HEAP

            //Console.WriteLine(P01);

            //Console.WriteLine(P01.X); //Invalid


            //New
            // 1. Allocate The Number Of Required Byte For The Object At Heap 
            // 2. Initialized The Allocated Bytes With The Default Value Of The Datatype
            // 3. Call User_Defined Constructor If Exists
            // 4. Assign The Object To The Reference 'P01'

            //Console.WriteLine(P01.X);//0
            //Console.WriteLine(P01.Y);//0

            //Point P02 = new Point();
            //P02.X = 12;

            //Console.WriteLine(P01.X); //0
            //Console.WriteLine(P02.X); //12

            //P01 = P02;

            //Console.WriteLine(P01.X); //12
            //Console.WriteLine(P02.X); //12 

            #endregion

            #region Object 

            //object O01;
            //Declare For Reference From Type 'Object'
            //O01 : Can Refer To Instance From Type 'Object' Or Any Type Inherited From Object

            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = 1.2;
            //O01 = true;
            //O01 = new Point02();


            //Console.WriteLine(O01); //1
            //Console.WriteLine(O01);//A
            //Console.WriteLine(O01);//1.2
            //Console.WriteLine(O01);//true
            //Console.WriteLine(O01);//C__2.Point02

            //Point p02 = new Point();

            //Console.WriteLine(p02.GetType());//C__2.Point02
            //Console.WriteLine(p02.ToString());//(0.0)
            //Console.WriteLine(p02);//(0,0)
            //p02.ToString();
            //Console.WriteLine(O01.GetHashCode());// Id : Indicate For The Address Of Object  -54267293
            //Console.WriteLine(p02.GetHashCode());// Id : Indicate For The Address Of Object  -1856234634

            //p02.GetHashCode();
            //p02.Equals();

            #endregion

            #region Casting 

            //Casting : Convert From Any Datatype To Any Datatype
            //1.Implicit Casting 

            //int x = 5;
            //double y = (double)x;//Implicit Casting (Safe Casting)
            //Console.WriteLine(y);

            //2.Explicit Casting 

            //double x = 2.5;
            //int y = (int)x; // Explicit Casting (UnSafe)
            //Console.WriteLine(y); //2

            //long x = 10000000000000000;
            //int y = (int) x; // Explicit Casting (UnSafe)
            //Console.WriteLine(y); //1874919424

            #endregion

            #region Parse 

            ////Parse : Function 

            //Console.WriteLine(value: "Enter Your Age : ");

            //int Age = int .Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);

            //Console.WriteLine(value: "Enter Your GPA : ");
            //double GPA = double.Parse(Console.ReadLine());
            //Console.WriteLine("GPA " + GPA );

            ////Console.ReadLine(); 

            #endregion

            #region Convert

            // Convert : Class

            // Console.WriteLine(value: "Enter Your Age : ");

            // int Age =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Age : " + Age); 

            #endregion

            #region TryParse

            //TryParse  

            //Console.WriteLine(value: "Enter Your Age : ");

            //int Age;

            //bool Flag = int.TryParse(Console.ReadLine(), out Age);

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("Flage : " + Flag);

            #endregion

            #region Fractions And Discards 

            //double x = 1.5;
            //float y = 1.5F;
            //decimal z = 1.5M;

            //int x = 1_000_000_000; //Discard _ 

            //Console.WriteLine(x);

            #endregion

            #region Operators 

            //1.Unary Operators ==> Works On One Operand (Variable) ++ --

            //int x = 10;
            //++
            //x++; // pstFix [Print The Increment]

            //++x; // Prefix [Increment Then Print ]

            //Console.WriteLine(++x); //11
            //Console.WriteLine(x++); //10
            //Console.WriteLine(x); //11

            //--
            //x--;  // pstFix [Print The Decrement]

            //--x; // Prefix [Decrement Then Print]

            //Console.WriteLine(--x);//9
            //Console.WriteLine(x--); //10 
            //Console.WriteLine(x); //9




            //2. Binary Operators ==> Works On Two Operands (Varibles) 
            // + - / * % 
            //int Sum, Mul, Sub, Mod;

            //int Number01=2 ,Number02 = 6;
            //Sum = Number01 + Number02;// 2+6 = 8
            //Mul = Number01 * Number02;// 2*6 = 12
            //Sub = Number01 - Number02;// 2-6 = -4
            //Mod = Number01 % Number02;// 2%6 = 2

            //23 % 3 = 2 



            //3. Assignment Operators ==> 

            //int X ; 
            // X = 4 ; 
            // X +=2 ; //x = x + 2 //6 
            // X -=2 ; //x = x - 2 
            // X *=2 ; //x = x * 2 
            // X /=2 ; //x = x / 2 
            // X %=2 ; //x = x % 2 



            //4. Relational Operators [Comparsion]

            //int X = 6 , Y = 5;
            //Console.WriteLine(X==Y); //False
            //Console.WriteLine(X != Y); //True
            //Console.WriteLine(X > Y); //True
            //Console.WriteLine(X < Y); //False
            //Console.WriteLine(X >= Y); //True
            //Console.WriteLine(X <= Y); //Falus


            //5. Logical Operators [AND , OR , NOT ]
            //Console.WriteLine(!false); // True , ! => Not
            //Console.WriteLine(false && true); // False , && => And Short Circuit
            //Console.WriteLine(false ||true); // True , || => OR Short Circuit



            //6. Bitwise Operators 
            //Console.WriteLine(!false); // True , ! => Not
            //Console.WriteLine(false & true); // False , && => And Long Circuit
            //Console.WriteLine(false |true); // True , || => OR Long Circuit




            //7. Ternar  Operators [Conditional Operator]
            //bool flag = 4 > 2;
            //Console.WriteLine(flag); //True

            //string flag = 4 > 2 ? "True" : "False";
            //Console.WriteLine(flag); // True

            //string flag = 4 < 2 ? "Correct " : "Not Correct";
            //Console.WriteLine(flag); // Not Correct

            #endregion

            #region Operator Priorty [Precedence] and Associtvity

            /*
             
              1. Unary Operator (Prefix)
              2. Round Braces
              3. * / %
              4. + -

             */

            // int a = 20 ; 
            // int b = 10 ;
            // int c = 15 ; 
            // int d = 5  ;
            //int e 

            //e = (a + b ) * c / d ; //(30 * 15)/5

            //e = ((a + b ) * c) /d ; //(30 * 15)/5

            //e = (a + b ) * (c / d ) ; // (30) * (15 /5)

            //e = a + ( b * c ) / d ; // 20 + (150 / 5 )  

            #endregion

        }

    }

}
