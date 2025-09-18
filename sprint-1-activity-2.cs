//Menu
void Menu()
{
   Console.WriteLine(@"Select the program you want to check:
1 for 'grades from a course'
2 for 'singing contest'
3 for 'shopping cart'
4 for 'employees management system'");
  
   string option = Console.ReadLine();
  
   switch (option)
   {
       case "1":
           Grades();
           break;
       case "2":
           SingingContest();
           break;
       case "3":
           ShopingCart();
           break;
       case "4":
           EmployeesManagement();
           break;
   }
}

Menu();
//---------------------------------------------------grades from a course-----------------------------------------------
void Grades()
{
   bool done = true;
   List<int> grades = new List<int>();
   int average = 0;
   

//Gets user's data and validates input (values between 1 and 5)
   while (done)
   {
       Console.WriteLine(@"Please, introduce your student's grades, once you finish, please type 'done': ");
       string input = Console.ReadLine().ToLower();

       
       if (input == "done")
       {
           done = false;
       }
       else
       {
           if (int.TryParse(input, out int grade))
           {
               if (grade > 0 && grade <= 5)
               {
                   grades.Add(grade);
               }
               else
               {
                   Console.WriteLine("Invalid grade, only values from 0 to 5");
               }
           }
       }
   }
   

//Prints students grades and indicates whether they passed or not
   foreach (int grade in grades)
   {
       Console.Write(grade + " ");
       if (grade >= 3)
       {
           Console.WriteLine("The student passed");
       }
       else
       {
           Console.WriteLine("The student failed");
       }
   }
   

//Prints a message in case there are grades below 3
   foreach (int grade in grades)
   {
       if (grade < 3)
       {
           Console.WriteLine("There are students with low performance");
           break;
       }
   }
   

//Adds every grade in order to calculate average
   foreach (int grade in grades)
   {
       average += grade;
   }

   
   Console.WriteLine($"The average of the group is = {average/grades.Count}");
}


//------------------------Concurso de canto-----------------------------------------------------------------------------


void SingingContest()
{
   List<string> participants = new List<string>();
   bool done = true;
   
   
//Gets user's input
   while (done)
   {
       Console.WriteLine("Please, introduce the name of each participant, once you finish, please type 'done': ");
       string participant = Console.ReadLine().ToLower();


       if (participant == "done")
       {
           done = false;
       }
       else
       {
           participants.Add(participant);
       }
   }
   

//Prints the whole list of participants
   foreach (string participant in participants)
   {
       Console.WriteLine(participant);
   }

   
//Returns all participants whose name starts by "A"
   List<string> namesStartingInA = participants.FindAll(participant => participant.StartsWith("a"));
   if (namesStartingInA.Count == 0)
   {
       Console.WriteLine("There are no participants whose name starts with 'A': ");
   }
   else
   {
       Console.WriteLine("Participant's name starting with 'A': ");
       foreach (string name in namesStartingInA)
       {
           Console.WriteLine(name);
       }
   }
  
  
//Participants CRUD
   Console.WriteLine(@"Select the action you want to do:
1. Add a new participant
2. Remove a participant
3. Update a participant
4. Leave this menu");
   string option = Console.ReadLine();
   switch (option)
   {
       case "1":
           Console.WriteLine("Introduce the new participant: ");
           string newParticipant = Console.ReadLine().ToLower();
           if (newParticipant != null)
           {
               participants.Add(newParticipant);
               Console.WriteLine("List of participants updated");
               foreach (string participant in participants)
               {
                   Console.WriteLine(participant);
               }
               break;
           }
           else
           {
               Console.WriteLine("Please, write something");
               break;
           }
       case "2":
           Console.WriteLine("Introduce the participant's name: ");
           string removedParticipant = Console.ReadLine().ToLower();
           if (removedParticipant != null)
           {
               participants.Remove(removedParticipant);
               Console.WriteLine("List of participants updated");
               foreach (string participant in participants)
               {
                   Console.WriteLine(participant);
               }
               break;
           }
           else
           {
               Console.WriteLine("Please, write something");
               break;
           }
       case "3":
           Console.WriteLine("Introduce the participant's name: ");
           string updatedParticipant = Console.ReadLine().ToLower();
           if (updatedParticipant != null)
           {
               int index = participants.IndexOf(updatedParticipant);
               Console.WriteLine("What is the new participant's name?");
               string newName = Console.ReadLine();
               participants[index] = newName;
               Console.WriteLine("List of participants updated");
               foreach (string participant in participants)
               {
                   Console.WriteLine(participant);
               }
               break;
           }
           else
           {
               Console.WriteLine("Please, write something");
               break;
           }
   }
}

// -------------------------------------------- carrito de compras------------------------------------------------------

void ShopingCart()
{
   List<dynamic> cart = new List<dynamic>();
   int total = 0;
   bool done = true;
   bool running = true;
   while (done)
   {
       Console.WriteLine(@"Introduce your products, once you finish, please type 'done': ");
       string products = Console.ReadLine().ToLower();
       if (products == "done")
       {
           done = false;
       }
       else
       {
           Console.WriteLine("How many units would you like: ");
           string inputUnits = Console.ReadLine();
           if (int.TryParse(inputUnits, out int units))
           {
               if (units >= 1)
               {
                   Console.WriteLine($"{units} units added");
               }
               else
               {
                   Console.WriteLine("You don't have any units");
                   break;
               }
           }
           else
           {
               Console.WriteLine("Only numbers are allowed");
               break;
           }
           Console.WriteLine("How much does it cost: ");
           string inputPrice =  Console.ReadLine();
           if (int.TryParse(inputPrice, out int price))
           {
               Console.WriteLine("Price added");
           }
           else
           {
               Console.WriteLine("Only numbers are allowed");
               break;
           }
           cart.Add(new {Name = products, Units = units, Price = price});
           total += units * price;
       }
   }
   Console.WriteLine("Your cart has been added: ");
   foreach (var product in cart)
   {
       Console.WriteLine($"Product: {product.Name}. \nUnits: {product.Units}. \nPrice/unit: {product.Price}");
   }

   if (total > 200)
   {
       Console.WriteLine($"Given that your purchase was over 200, you obtained 10% discount. \nYour total is: {total * 0.9}");
   }
   else
   {
       Console.WriteLine($"Your total is: {total}");
   }

   while (running)
   {
       Console.WriteLine(@"Select the action you want to do:
1. Add a new product
2. Remove a product
3. Update a product
4. Leave this menu");
       string option = Console.ReadLine();
       switch (option)
       {
           case "1":
               bool done2 = true;
               while (done2)
               {
                   Console.WriteLine(@"Introduce the new product, once you finish, please type 'done': ");
                   string newProduct = Console.ReadLine().ToLower();
                   if (newProduct == "done")
                   {
                       done2 = false;
                   }
                   else
                   {
                       Console.WriteLine("How many units would you like: ");
                       string inputUnits = Console.ReadLine();
                       if (int.TryParse(inputUnits, out int units))
                       {
                           if (units >= 1)
                           {
                               Console.WriteLine($"{units} units added");
                           }
                           else
                           {
                               Console.WriteLine("You don't have any units");
                               break;
                           }
                       }
                       else
                       {
                           Console.WriteLine("Only numbers are allowed");
                           break;
                       }
                       Console.WriteLine("How much does it cost: ");
                       string inputPrice =  Console.ReadLine();
                       if (int.TryParse(inputPrice, out int price))
                       {
                           Console.WriteLine("Price added");
                       }
                       else
                       {
                           Console.WriteLine("Only numbers are allowed");
                           break;
                       }
                       cart.Add(new {Name = newProduct, Units = units, Price = price});
                       total += units * price;
                   }
               }
               Console.WriteLine("List of products updated: ");
               foreach (var product in cart)
               {
                   Console.WriteLine($"Product: {product.Name}. \nUnits: {product.Units}. \nPrice/unit: {product.Price}");
               }

               if (total > 200)
               {
                   Console.WriteLine($"Given that your purchase was over 200, you obtained 10% discount. \nYour total is: {total * 0.9}");
               }
               else
               {
                   Console.WriteLine($"Your total is: {total}");
               }
               break;
           case "2":
               if (cart.Count == 0)
               {
                   Console.WriteLine("No products added. Leaving this menu...");
               }
               else
               {
                   Console.WriteLine("Introduce the product's name: ");
                   string removedProduct = Console.ReadLine().ToLower();
                   if (removedProduct != null)
                   {   
                       int index = cart.FindIndex(product => product.Name == removedProduct);
                       if (index >= 0)
                       {
                           cart.RemoveAt(index);
                           Console.WriteLine("List of products updated");
                           foreach (var product in cart)
                           {
                               Console.WriteLine($"Product: {product.Name}. \nUnits: {product.Units}. \nPrice/unit: {product.Price}");
                           }
                       }
                       else
                       {
                           Console.WriteLine("Product not found");
                       }
                   }
                   else
                   {
                       Console.WriteLine("Please, write something");
                   }
               }
               break;
           case "3":
               if (cart.Count == 0)
               {
                   Console.WriteLine("No products added. Leaving this menu...");
               }
               else
               {
                   Console.WriteLine("Introduce the product's name: ");
                   string updatedProduct = Console.ReadLine().ToLower();
                   if (updatedProduct != null)
                   {   
                       int index = cart.FindIndex(product => product.Name == updatedProduct);
                       if (index >= 0)
                       {
                           var oldProduct = cart[index];
                           Console.WriteLine("Enter new units: ");
                           string inputUnits = Console.ReadLine();
                           if (int.TryParse(inputUnits, out int newUnits))
                           {
                               cart[index] = new { 
                                   Name = oldProduct.Name, 
                                   Units = newUnits,           
                                   Price = oldProduct.Price    
                               };
                               Console.WriteLine("List of products updated");
                           }
                           foreach (var product in cart)
                           {
                               Console.WriteLine($"Product: {product.Name}. \nUnits: {product.Units}. \nPrice/unit: {product.Price}");
                           }
                       }
                       else
                       {
                           Console.WriteLine("Product not found");
                       }
                   }
                   else
                   {
                       Console.WriteLine("Please, write something");
                   }
               }
               break;
           case "4":
               running = false;
               Console.WriteLine("Leaving this menu...");
               break;
   }
   }
}

//------------------------------------------Company employees management system-----------------------------------------

void EmployeesManagement()
{
    List<dynamic> employees = new List<dynamic>();
    bool done = true;
    int minors = 0;
    bool running = true;
    while (done)
    {
        Console.WriteLine("Please introduce the employee's name, once you finish you can type 'done': ");
        string name = Console.ReadLine().ToLower();
        if (name == "done")
        {
            done = false;
        }
        else
        {
            Console.WriteLine("\nIntroduce the employee's age: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                if (age > 0 && age < 18)
                {
                    minors += 1;
                }
            }
            else
            {
                Console.WriteLine("Numbers only");
                break;
            }
            Console.WriteLine("\nIntroduce the employee's email: ");
            string email = Console.ReadLine();
            employees.Add( new {Name = name, Age = age, Email = email});
        }
    }

    if (employees.Count == 0)
    {
        Console.WriteLine("No employees were added");
    }
    else
    {
        Console.WriteLine("Employees have been added: ");
        foreach (var employee in employees)
        {
            Console.WriteLine($"\n\nEmployee: {employee.Name}. \nAge: {employee.Age}. \nEmail: {employee.Email}");
        }
    }
    Console.WriteLine($"\nEmployees below 18 years old: {minors}");
    while (running)
   {
       Console.WriteLine(@"Select the action you want to do:
1. Add a new employee
2. Remove an employee
3. Update an employee
4. Leave this menu");
       string option = Console.ReadLine();
       switch (option)
       {
           case "1":
               bool done2 = true;
               while (done2)
               {
                   Console.WriteLine("\nIntroduce the new employee, once you finish, please type 'done': ");
                   string name = Console.ReadLine().ToLower();
                   if (name == "done")
                   {
                       done2 = false;
                   }
                   else
                   {
                       Console.WriteLine("\nIntroduce the employee's age: ");
                       string input = Console.ReadLine();
                       if (int.TryParse(input, out int age))
                       {
                           if (age > 0 && age < 18)
                           {
                               minors += 1;
                           }
                       }
                       else
                       {
                           Console.WriteLine("Numbers only");
                           break;
                       }
                       Console.WriteLine("\nIntroduce the employee's email: ");
                       string email = Console.ReadLine();
                       employees.Add( new {Name = name, Age = age, Email = email});
                   }
               }
               if (employees.Count == 0)
                   {
                       Console.WriteLine("No employees were added");
                   }
                   else
                   {
                       Console.WriteLine("Employees have been added: ");
                       foreach (var employee in employees)
                       {
                           Console.WriteLine($"\n\nEmployee: {employee.Name}. \nAge: {employee.Age}. \nEmail: {employee.Email}");
                       }
                   }
                   Console.WriteLine($"\nEmployees below 18 years old: {minors}");
               break;
           case "2":
               if (employees.Count == 0)
               {
                   Console.WriteLine("\nNo employees added. Leaving this menu...");
               }
               else
               {
                   Console.WriteLine("\nIntroduce the employee's name: ");
                   string removedEmployee = Console.ReadLine().ToLower();
                   if (removedEmployee != null)
                   {   
                       int index = employees.FindIndex(employee => employee.Name == removedEmployee);
                       if (index >= 0)
                       {
                           employees.RemoveAt(index);
                           Console.WriteLine("\nList of employees updated");
                           foreach (var employee in employees)
                           {
                               Console.WriteLine($"Employee: {employee.Name}. \nAge: {employee.Age}. \nEmail: {employee.Email}");
                           }
                       }
                       else
                       {
                           Console.WriteLine("\nEmployee not found");
                       }
                   }
                   else
                   {
                       Console.WriteLine("\nPlease, write something");
                   }
               }
               break;
           case "3":
               if (employees.Count == 0)
               {
                   Console.WriteLine("\nNo employees added. Leaving this menu...");
               }
               else
               {
                   Console.WriteLine("Introduce the employee's name: ");
                   string updatedEmployee = Console.ReadLine().ToLower();
                   if (updatedEmployee != null)
                   {   
                       int index = employees.FindIndex(employee => employee.Name == updatedEmployee);
                       if (index >= 0)
                       {
                           var oldEmployee = employees[index];
                           Console.WriteLine("Enter new email: ");
                           string newEmail = Console.ReadLine();
                           employees[index] = new { 
                               Name = oldEmployee.Name, 
                               Email = newEmail,           
                               Age = oldEmployee.Age    
                           };
                           Console.WriteLine("List of employees updated");
                           
                           foreach (var employee in employees)
                           {
                               Console.WriteLine($"Employee: {employee.Name}. \nAge: {employee.Age}. \nEmail: {employee.Email}");
                           }
                       }
                       else
                       {
                           Console.WriteLine("Employee not found");
                       }
                   }
                   else
                   {
                       Console.WriteLine("Please, write something");
                   }
               }
               break;
           case "4":
               running = false;
               Console.WriteLine("Leaving this menu...");
               break;
   }
   }
}
