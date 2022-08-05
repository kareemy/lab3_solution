using lab3_solution;

// Task 3: Create our first mad scientist
MadScientist madScientist = new MadScientist();

// Fill in the properties for the mad scientist object
madScientist.FirstName = "Kareem";
madScientist.LastName = "Dana";
madScientist.Age = 35;
madScientist.LastSeen = DateTime.Parse("1/23/2020");

// Make a database connection with the using statement
using (var db = new AppDbContext())
{ // Log in to database/Open connection
    db.Database.EnsureCreated();    // Create our database to begin with
    db.Add(madScientist);           // Add our entity to the database
    db.SaveChanges();               // Save changes to the disk
} // Log out of database/Close connection