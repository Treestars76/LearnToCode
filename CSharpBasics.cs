// When using calls outside of the default namespace, the namespace those calls belong to must be initialized.
// System is very common namespace and Let's you make system calls. In this script "DateTime" is the only call that requires System.
using System;

// In this script, "List<>" is the only call that requires System.Collections.Generic.
using System.Collections.Generic;

// Every script must have at least one Top-Level class. Today we are making a Poop Factory, so let's call our parent class PoopFactory.
public class PoopFactory
{
    // Define what poop is with a class. THIS IS NOT POOP! This is just a set of definitions for what constitutes poop, but we can use this to make poop!
    public class Poop
    {
        // List all the properties of Poop. These properties can be specified after Poop creation. Variables must be declared with their data type (int, float, double etc.) and name.
        public int Size; // An int variable represents any integer value.
        public float Moisture; // a float variable can represent integers and decimals. They should always have an "f" after the value.

        // You can also have set criteria that all new Poops will have on creation.
        public string Colour = "Brown"; // A string uses "" to save any plain text data.

        // Classes can also hold methods, which are what execute code.
    }

    // Create Poop! This simple declaration takes the Poop class and uses it to make a real Poop object that can be used!
    // This is identical to variable creation, but here Poop is the data type.
    // Because Poop is a complex data type, we should explicitly create a "new" instance of it. Adding "()" creates a new object.
    private Poop MyPoop = new Poop();

    // If you plan on creating a lot of Poop, a method helps you do that. You can call PoopMachine() anywhere and it will output a brand new Poop for you.
    // The specified data type in the method declaration is what the method returns. Your return value must have the same data type specified in the declaration.
    // PoopMachine() makes Poop, and must return a Poop to the caller.
    private Poop PoopMachine()
    {
        // Create Poop!
        Poop newPoop = new Poop();

        // Hand the newPoop to whoever requested it.
        return newPoop;
    }

    // Methods can also be used to set the parameters of the Poop you want to create. AdvancedPoopMachine() will create a new Poop that already has all the ideal properties!
    private Poop AdvancedPoopMachine()
    {
        // Create Poop!
        Poop newAdvancedPoop = new Poop();

        // Define the parameters of the ideal Poop.
        newAdvancedPoop.Size = 5;
        newAdvancedPoop.Moisture = 0.3f;

        // You can overwrite defaults as well.
        newAdvancedPoop.Colour = "Red";

        // Hand the created Poop back.
        return newAdvancedPoop;
    }

    // You can use the same method to make custom poops on the fly! UltraAdvancedPoopMachine() will create any Poop you want.
    // Use the "()" to define the parameters this method needs. To call UltraAdvancedPoopMachine, you must give it all the parameters it asks for.
    // We will make this method public so that anyone anywhere can use this method to make their own Poop!
    public Poop UltraAdvancedPoopMachine(int PoopSize, float PoopMoisture)
    {
        // Let's use our basic PoopMachine method to give us a new Poop instead of creating one on our own.
        Poop newUltraAdvancedPoop = PoopMachine();

        // Use the Poop requester's preferences when modifying the Poop.
        newUltraAdvancedPoop.Size = PoopSize;
        newUltraAdvancedPoop.Moisture = PoopMoisture;

        // Hand the Poop requester's custom Poop back!
        return newUltraAdvancedPoop;
    }

    // A void method does not hand anything back, and does not need a data type (like Poop), it will simply execute code when called.
    private void MyPerfectPoopMachine()
    {
        // Use our UltraAdvancedPoopMachine to give us the perfect Poop for our current applciation.
        Poop myPerfectPoop = UltraAdvancedPoopMachine(12, 0.5f);

        // NOTE: MyPerfectPoopMachine is functionally useless. It only creates a Poop and does nothing with it!
    }

    // Our current Poop machines are fantastic, but they can only make poop one at a time. We need a bigger, faster Poop machine if we are ever going to meet demand!
    private void SuperPoopMachine(int OrderQuantity, int DesiredSize, float DesiredMoisture)
    {
        // Our SuperPoopMachine() should only be used for big orders, so Let's make a threshold for what the machine will accept.
        int MinimumOrderSize = 10;

        // We can enforce this threshold by checking every order with an if statement.
        if (OrderQuantity > MinimumOrderSize)
        {
            // If the OrderQuantity is LARGER THAN the MinimumOrderSize, the MassProducePoop() Method will be executed. Otherwise, do nothing.
            MassProducePoop();
        }

        // We can create a method inside our method; this makes it so that only the SuperPoopMachine() can use it. Local methods cannot have an access modifier (public, private, etc.).
        void MassProducePoop()
        {
            // A for loop is a type of loop that executes code repeatedly. It is made of 3 components
            // 1. Initializer: This starts the loop at a given value. Here we create the integer "PoopCount" and set it to 0. This is the variable that controls the loop.
            // 2. Condition: This is what decides when the loop proceeds, works just like an if statement. Here, as long as PoopCount is below the OrderQuantity, the loop will execute.
            // 3. Update: After execution, this expression will update the control variable to determine the next step of the for loop.
            //    "PoopCount++" is shorthand for increment by 1 and is the same as "PoopCount = PoopCount + 1". "PoopCount--" would decrement instead. You may use any valid expression.
            for (int PoopCount = 0; PoopCount < OrderQuantity; PoopCount++)
            {
                // Produce Poop to the client's specifications using our UltraAdvancedPoopMachine()
                Poop ProducedPoop = UltraAdvancedPoopMachine(DesiredSize, DesiredMoisture);

                // Our Poop machines are perfect, but it makes clients happier if all Poop gets a QC check. Let's create another local method for the SuperPoopMachine() to test Poops.
                // If PoopQC() detects out-of-spec Poop, it will return a 1.
                // "-=" is a shorthand that means subtract. Depending on PoopQC()'s output, this can set the loop back. "+=" can be used to add instead.
                PoopCount -= PoopQC(ProducedPoop);

                // NOTE: MassProducePoop() instantly deletes all ProducedPoop the moment PoopCount iterates to the next step. It is functionally useless.
                // When making PoopMachines, make sure they save the Poop somewhere or use them for downstream executions!
            }
        }

        // PoopQC() is a method that can accept any Poop from SuperPoopMachine() for inspection. Remember, PoopQC must return an integer as is defined by the method declaration!
        int PoopQC(Poop PoopToTest)
        {
            if (PoopToTest.Size != DesiredSize)
            {
                // If the Size of the produced poop DOES NOT EQUAL the DesiredSize, send back a 1 to be subtracted from the loop's PoopCount.
                return 1;
            }

            // else is triggered when the if condition fails. It is common to chain an if statement right after.
            else if (PoopToTest.Moisture < DesiredMoisture || PoopToTest.Moisture > DesiredMoisture)
            {
                // If the Moisture of the produced poop is LESSER THAN DesiredMoisture OR it is GREATER THAN DesiredMoisture, send back a 1 to be subtracted from the loop's PoopCount. 
                return 1;
            }

            else
            {
                // If poop passes all QC checks send back a 0 to be subtracted from PoopCount.
                return 0;
            }
        }
    }

    // SCOPE & ACCESS MODIFIERS EXPLANATION

    // PUBLIC: Anyone who has access to the PoopFactory object can see and operate a public PoopMachine.
    // External scripts, child classes, and the factory itself all have full access.
    public void PublicPoopMachine() { }

    // PRIVATE: ONLY the PoopFactory itself can see and operate a private PoopMachine. Anyone outside of the PoopFactory cannot use it, including Child classes!
    // Private is the default modifier if it is never specified.
    private void PrivatePoopMachine() { }
    void PrivatePoopMachineToo() { } // Is also Private!

    // PROTECTED: ONLY the PoopFactory itself and its Child classes (classes that inherit from it) can see it.
    // Anyone outside the family tree (external scripts) cannot use a protected PoopMachine.
    protected void ProtectedPoopMachine() { }

    // Top-Level classes cannot be private or protected!
}

// So far, we have only made Poop inside the PoopFactory, but we should be to make poop anywhere without rewriting all the Poop code.
public class NewPoopSite
{
    // First, we need to make a new instance of PoopFactory at this new location because it is a class and not a real object.
    PoopFactory newPoopFactory = new PoopFactory();

    // Now anyone in the NewPoopSite can use the public members inside the new PoopFactory without rewriting all the code!
    private void GetPoop()
    {
        // Let's execute the public UltraAdvanedPoopMachine() in the new PoopFactory to create Poop offsite!
        newPoopFactory.UltraAdvancedPoopMachine(6, 0.9f);

        // Remember, the Poop class belongs to PoopFactory, if we want to make any new Poop objects outside of PoopFactory we must still use the Poop class as defined in PoopFactory.
        PoopFactory.Poop newExternalPoop = new PoopFactory.Poop();
    }

    // PoopFactories can run 24/7, but Let's have this new PoopFactory's machines only operate during daytime so the Poop workers can go home to their Poop families.
    // We can use a boolean method to return a simple true/false statement.
    // NOTE: "DateTime" is a class defined in the System namespace; you can call it directly with "System.DateTime" without needing to initialize the namespace. 
    private bool PoopFactoryIsOpen(DateTime Time)
    {
        // Let's declare working hours.
        int StartWork = 6;
        int EndWork = 22;

        // Now Let's do a check to see if the newPoopSite is open. Datetime.Hour is a property already defined in the DateTime class and can be used by all DateTime objects.
        if (Time.Hour >= StartWork && Time.Hour <= EndWork)
        {
            // If the evaluated Time is GREATER THAN OR EQUAL to StartWork AND also LESS THAN OR EQUAL TO EndWork, return true. 
            return true;
        }

        else
        {
            // Otherwise, return false.
            return false;
        }
    }

    // Now Let's make another Poop machine that strictly operates during work hours!
    private void EmployeeRespectfulPoopMachine(int OrderQuantity)
    {
        // We can create a variable that equals the current system time. Datetime.Now is a property already defined in the DateTime class and can be used by all DateTime objects.
        DateTime CurrentTime = DateTime.Now;

        // If the output of PoopFactoryIsOpen(CurrentTime) EQUALS true, this Poop machine will accept the order.
        if (PoopFactoryIsOpen(CurrentTime) == true)
        {
            // If we actually want our Poop machine to be useful, we should have it do someting.
            // Let's create an array to store all the Poops we produce. To create an array, just add "[]" after the data type. This creates an array of Poops, instead of 1 Poop object.
            // The Size of the array is how many items it will store. Let's set it to OrderQuantity so that the array can store exactly as many Poops as is ordered. 
            PoopFactory.Poop[] PoopOrderList = new PoopFactory.Poop[OrderQuantity];

            // Let's create a count variable to keep track of the produced Poop. The Poop machine will start at 0 Poops.
            int PoopCount = 0;

            // A while loop will continue to run as long as its condition is true; we can use this to continually produce Poop until the order is fullfilled!
            while (PoopCount < OrderQuantity)
            {
                // Let's use our UltraAdvancedPoopMachine() because it is the only public Poop machine in the PoopFactory class.
                PoopFactory.Poop ProducedPoop = newPoopFactory.UltraAdvancedPoopMachine(10, 0f);

                // Save the ProducedPoop to the array position [PoopCount]. So every PoopCount (0, 1, 2...) has an associated Poop. 
                PoopOrderList[PoopCount] = ProducedPoop;

                // After producing a new Poop and saving it, we should update the count by 1. If not, the Poop machine will produce infinite Poop and the Poop economy will crash!
                PoopCount++;
            }

            // After the PoopOrderList array is filled, let's send the array to storage so the Poops aren't lost after the Poop machine finishes executing.
            StorePoops(PoopOrderList);
        }
    }

    // We can use a List<> to store all of our Poops. Lists have no fixed size unlike arrays.
    // NOTE: "List<>" requires the System.Collections.Generic namespace.
    private List<PoopFactory.Poop> PoopWarehouse = new List<PoopFactory.Poop>();

    // We need a method that can store ReceivedPoops in our PoopWarehouse List<>. StorePoops can recieve any PoopFactory.Poop array.  
    private void StorePoops(PoopFactory.Poop[] ReceivedPoops)
    {
        // A foreach loop can look at any array or list, and execute once for each specified item contained within.
        // Here, it looks for PoopFactory.Poop objects found in the ReceivedPoops array and declares a temporary reference variable named SinglePoop.
        foreach (PoopFactory.Poop SinglePoop in ReceivedPoops)
        {
            // Add the referenced Poop object to the PoopWarehouse List. ".Add()" is a method already defined in the List<> class and can be used by all List<> objects.
            PoopWarehouse.Add(SinglePoop);
        }
    }
}
