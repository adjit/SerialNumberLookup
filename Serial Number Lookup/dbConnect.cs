using System;

public class dbConnect
{
    public string connection { get; }

	public dbConnect()
	{
        try
        {
            connection = System.IO.File.ReadAllText(@"\\METRO-FILE1\Metropolitan Sales Docs\1-Deployment\dbConnect\dbConnection");
        }
        catch (Exception e)
        {
            System.Windows.Forms.MessageBox.Show("Unable to get connection string for database.");
        }
	}
}
