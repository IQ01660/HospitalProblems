using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial sector objects
            Sector sec001 = new Sector("Onkology");
            Sector sec002 = new Sector("Dermatology");
            Sector sec003 = new Sector("Laboratory");
            Sector sec004 = new Sector("Surgery");
            Sector sec005 = new Sector("Gynecology");
            Sector sec006 = new Sector("Dental");
            //initial doctor objects
            Doctor doc001 = new Doctor("Jennifer", "001ONK", "Onkology");
            Doctor doc0001 = new Doctor("Steve", "0001ONK", "Onkology");
            Doctor doc002 = new Doctor("Jessica", "002DER", "Dermatology");
            Doctor doc0002 = new Doctor("Teodor", "0002DER", "Dermatology");
            Doctor doc003 = new Doctor("Michael", "003LAB", "Laboratory");
            Doctor doc0003 = new Doctor("Zoe", "0003LAB", "Laboratory");
            Doctor doc004 = new Doctor("Gregory", "004SUR", "Surgery");
            Doctor doc0004 = new Doctor("Luiza", "0004SUR", "Surgery");
            Doctor doc005 = new Doctor("Sam", "005GYN", "Gynecology");
            Doctor doc0005 = new Doctor("Grieta", "0005GYN", "Gynecology");
            Doctor doc006 = new Doctor("Charles", "006DEN", "Dental");
            Doctor doc0006 = new Doctor("Angelina", "0006DEN", "Dental");
            
            // ***** START OF THE PROGRAM *****   
                
            Console.Write(" Welcome to the Hospital System \n --- Please enter the password to proceed : ");
            string passwordHolder = Console.ReadLine();
            if (passwordHolder == "admin")
            {
                string choiceHolder;
                int control;
                bool isCorrectSector;
                string sectorHolder;
                do
                {
                    //controlling variables
                    control = 0;
                    isCorrectSector = false;
                    //Main Menu
                    Console.WriteLine("---Main Menu--- \n Choose an Option and press enter \n \n 1 Sobeler \n 2 Doctors \n");
                    //checking choice
                    do
                    {
                        Console.Write("Your Choice : ");
                        choiceHolder = Console.ReadLine();
                        if (choiceHolder == "1" || choiceHolder == "2")
                        {
                            break;
                        }
                    } while (choiceHolder != "1" || choiceHolder != "2");
                    // results from choosing either 1 or 2
                    if (choiceHolder == "1")
                    {
                        Console.WriteLine(" \n ---Sobeler Menu--- \n Choose an Option and press enter \n \n 1.1 Show Sobeler \n 1.2 Add Sobeler \n 1.3 Remove Sobeler \n 'm' For Main Menu \n");
                        //checking choice
                        do
                        {
                            Console.Write("Your Choice : ");
                            choiceHolder = Console.ReadLine();
                            if (choiceHolder == "1.1" || choiceHolder == "1.2" || choiceHolder == "1.3" || choiceHolder == "m")
                            {
                                break;
                            }
                        } while (choiceHolder != "1.1" || choiceHolder != "1.2" || choiceHolder != "1.3" || choiceHolder != "m");
                        // results from choosing either 1.1 , 1.2 or 1.3
                        if (choiceHolder == "1.1")
                        {
                            foreach (var item in SectorListHolder.sectorObjects)
                            {
                                Console.WriteLine(item.Field);
                                Console.WriteLine("---");
                            }
                            continue;
                        } 
                        else if (choiceHolder == "1.2")
                        {
                            Console.WriteLine(" Enter the field of the new sector");
                            string newFieldSector = Console.ReadLine();
                            // not very sure about creating object here
                            new Sector(newFieldSector);
                            Console.WriteLine(" Sector {0} is successfully added",newFieldSector);
                            continue;
                        }
                        else if (choiceHolder == "1.3")
                        {
                            foreach (var item in SectorListHolder.sectorObjects)
                            {
                                Console.WriteLine(item.Field);
                                Console.WriteLine("---");
                            }
                            
                            //checking the correctness of field (choiceHolder)
                            do
                            {
                                Console.WriteLine(" Enter the field of the sector you want to remove ");
                                choiceHolder = Console.ReadLine();
                                foreach (var element in SectorListHolder.sectorObjects)
                                {
                                    if (choiceHolder == element.Field)
                                    {
                                        control = 1;
                                    }
                                }
                            } while (control == 0);
                            // removing the Sector
                            for (int i = 0; i < SectorListHolder.sectorObjects.Count; i++)
                            {
                                if (choiceHolder == SectorListHolder.sectorObjects[i].Field)
                                {
                                    SectorListHolder.sectorObjects.Remove(SectorListHolder.sectorObjects[i]);
                                    break;
                                }
                            }
                            Console.WriteLine(" Sector {0} is successfully removed \n", choiceHolder);
                            continue;
                        }
                        // if the choice is m
                        else
                        {
                            continue;
                        }
                    }
                    // if choice is 2
                    else
                    {
                        Console.WriteLine(" \n ---Doctors Menu--- \n Choose a Sector Field and press enter \n \n ");
                        //choices of sectors
                        foreach (var itemChoice in SectorListHolder.sectorObjects)
                        {
                            Console.WriteLine("- " + itemChoice.Field);
                        }
                        //checking the choice
                        do
                        {
                            Console.WriteLine(" Enter the field of the doctors ");
                            sectorHolder = Console.ReadLine();
                            foreach (var element in SectorListHolder.sectorObjects)
                            {
                                if (sectorHolder == element.Field)
                                {
                                    isCorrectSector = true;
                                }
                            }
                        } while (isCorrectSector == false);

                        Console.WriteLine(" \n Choose an Option and press enter \n \n 2.1 Show Doctors \n 2.2 Add Doctors \n 2.3 Remove Doctors \n 'm' For Main Menu \n");
                        //checking choice
                        do
                        {
                            Console.Write("Your Choice : ");
                            choiceHolder = Console.ReadLine();
                            if (choiceHolder == "2.1" || choiceHolder == "2.2" || choiceHolder == "2.3" || choiceHolder == "m")
                            {
                                break;
                            }
                        } while (choiceHolder != "2.1" || choiceHolder != "2.2" || choiceHolder != "2.3" || choiceHolder != "m");

                        if (choiceHolder == "2.1")
                        {
                            // LIST OF DOCTORS IN A SPECIFIC SECTOR
                            Console.WriteLine("List of Doctors in {0} Sector", sectorHolder);
                            foreach (var item in DoctorListHolder.doctorObjects)
                            {
                                if (item.Type == sectorHolder)
                                {
                                    Console.WriteLine(item.Name + " | ID: " + item.ID + " | Field: " + item.Type);
                                }
                            }
                        }
                        else if (choiceHolder == "2.2")
                        {
                            Console.WriteLine(" Enter the Name of the new Doctor");
                            string newNameDoc = Console.ReadLine();
                            Console.WriteLine(" Enter the ID of the new Doctor");
                            string newIDDoc = Console.ReadLine();
                            // not very sure about creating object here
                            new Doctor(newNameDoc , newIDDoc , sectorHolder);
                            Console.WriteLine(" Doctor {0} is successfully added \n", newNameDoc);
                            continue;
                        }
                        else if (choiceHolder == "2.3")
                        {
                            // list of removable doctors
                            foreach (var item in DoctorListHolder.doctorObjects)
                            {
                                if (item.Type == sectorHolder)
                                {
                                    Console.WriteLine(item.Name + " | ID: " + item.ID + " | Field:" + sectorHolder);
                                    Console.WriteLine("---");
                                }
                                
                            }

                            //checking the correctness of Doctor Name (choiceHolder)
                            do
                            {
                                Console.WriteLine(" Enter the Name of the Doctor you want to remove ");
                                choiceHolder = Console.ReadLine();
                                foreach (var element in DoctorListHolder.doctorObjects)
                                {
                                    if (choiceHolder == element.Name && sectorHolder == element.Type)
                                    {
                                        control = 1;
                                    }
                                }
                            } while (control == 0);
                            // removing the Doctor
                            for (int j = 0; j < DoctorListHolder.doctorObjects.Count; j++)
                            {
                                if (choiceHolder == DoctorListHolder.doctorObjects[j].Name)
                                {
                                    DoctorListHolder.doctorObjects.Remove(DoctorListHolder.doctorObjects[j]);
                                    break;
                                }
                            }
                            Console.WriteLine(" Doctor {0} is successfully removed \n", choiceHolder);
                            continue;
                        }
                        // if the choice is m 
                        else
                        {
                            continue;
                        }

                    }
                    
                } while (true);
            }
            // if the most initial password is invalid
            else
            {
                Console.WriteLine(" --- Access Denied --- ");
            }
        }
    }
    class SectorListHolder
    {
        // SECTOR OBJECTS STORING LIST
        public static List<Sector> sectorObjects = new List<Sector>();
    }
    class DoctorListHolder
    {
        // DOCTOR OBJECTS STORING LIST
        public static List<Doctor> doctorObjects = new List<Doctor>();
    }
    // THE SECTOR CLASS
    class Sector
    {
        // PROPERTIES FOR SECTOR
        public string Field;
        // CONSTRUCTOR FOR SECTOR
        public Sector(string _field)
        {
            // adding the sector object to the list when creating it
            SectorListHolder.sectorObjects.Add(this);
            this.Field = _field;
        }
    }
    // THE DOCTOR CLASS
    class Doctor 
    {
        // PROPERTIES FOR DOCTOR
        public string Name;
        public string ID;
        public string Type;
        // CONSTRUCTOR FOR DOCTOR 
        public Doctor(string _name , string _id , string _type) 
        {
            // adding the doctor object to the list when creating it
            DoctorListHolder.doctorObjects.Add(this);
            this.Name = _name;
            this.ID = _id;
            this.Type = _type;
        }
    }
   
}
