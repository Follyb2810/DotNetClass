using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace HumanGeneration
{
    class Human
    {

        //! member variable
        static int numOfPeople = 0;
        private string firstName;
        private string lasttName;
        private int age;
        private string eyeColor;
        //! constructor
        public Human(string _firstName, string _lastName, int age, string eyeColor)
        {
            firstName = _firstName;
            lasttName = _lastName;
            this.eyeColor = eyeColor;
            this.age = age;
            // this.firstName = _firstName; //? valid too
        }
        //? with incomplete parameter
        public Human(string _firstName, string _lastName, string eyeColor)
        {
            firstName = _firstName;
            lasttName = _lastName;
            this.eyeColor = eyeColor;

            // this.firstName = _firstName; //? valid too
        }
        //? with few parameter
        public Human(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lasttName = _lastName;
            // this.firstName = _firstName; //? valid too
        }
        //! having multiple
        //? zero paremeter 
        public Human()
        {
            System.Console.WriteLine();
        }

        //!memeber
        public static void HumanMethod() { }
        //! member
        public void IntroduceMyself()
        {
            numOfPeople++;
            if (age != 0)
            {
                System.Console.WriteLine(numOfPeople);
                System.Console.WriteLine("Hi, i am from " + firstName + " " + lasttName + " and am " + age + " years old, my eyes colors  is " + eyeColor);

            }
            // else if(eyeColor is null){
            else if (eyeColor == null)
            {

                System.Console.WriteLine("hi, im {0} {1} ;", firstName, lasttName);
            }
            else if (lasttName != null && firstName != null)
            {

                System.Console.WriteLine("hi, im {0} {1} ;", firstName, lasttName);
            }
            else if (firstName != null)
            {

                System.Console.WriteLine("hi, im {0};", firstName);
            }
            else
            {
                System.Console.WriteLine("hi, im {0} {1} ;my eyee color is {2}", firstName, lasttName, eyeColor);
            }
        }
    }
    class Box
    {
        //! memnber field approach 1
        private int height;
        public int width;
        private int length = 3;
        private int volume;
        private int weight;

        //? properties

        //!  simple getter and setter 1 approach 2
        public int AreaOfCircle { set; get; }
        //? complex properties 
        public int Weight{
            get { return this.weight;}
            set { this.weight = value;}
        }
        //* complex properties writting with 2
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }
        public int Volume {
            get { return height * width * length; }
        }
        //! constructor
        public Box(int _length,int _width,int _height){
            length = _length;
            weight= _width;
            height=_height;
        }
        //! method

        public void displayInfo()
        {
            System.Console.WriteLine("length i {0} and height is {1} and with is {2} and the volume is {3}", length, height, width, volume = (length * width * height));
        }
        //! setter for length
        public void setLength(int _length)
        {
            if (_length < 0)
            {
                throw new Exception("length should be higher than 0");
            }
            length = _length;
        }
        //! getter for lenth
        public int GetLength()
        {
            return this.length;
        }
        public int getVolume()
        {
            return length * width * height;
        }

    }
    class Members
    {
       private string memberName;
       private string jobTitle;
       private int salary;
       public int age;
       public string JobTitle {
        get {return jobTitle;}
        set {jobTitle = value;}
        }

        //method
        public void introducing(bool isFriend){
            if(isFriend){
                sharingPrivateInfo();
            }else{
                System.Console.WriteLine("hi my name is {0} and my job title is {1},i'm {2} years ols",memberName,jobTitle,age);
            }
        }
        private void sharingPrivateInfo(){
            System.Console.WriteLine("My salary is {0}",salary);
        }
        //! member
        public Members(){
            age= 30;
            salary=1000;
            memberName="folly";
            jobTitle="developer";
            System.Console.WriteLine("object created");
        }
        //! destructor or finalizer
        ~Members(){
            System.Console.WriteLine("deconstruction of memeber object");
        }
    }
}