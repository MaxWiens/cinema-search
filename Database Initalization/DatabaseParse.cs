private static string[,] ParseFile(string path) {

	// Read and store rows from text file.
	string[] rows = System.IO.File.ReadAllLines(path);
	
	// Establish boundries of return array.
	int rowCount = rows.Length;
	int fieldCount = (rows[0].Split(',')).Count;
	
	// Create return array.
	string[,] returnArr = new string[rowCount,fieldCount];
	
	// Iterate through rows from file and split at commas.
	for(int rowIndex=0; rowIndex<rowCount; rowIndex++) {
		string[] fields = rows[rowIndex].Split(',');
		
		// Insert the values from the fields in each row into return array.
		for(int fieldIndex=0; fieldIndex<fieldCount; fieldIndex++) {
			returnArr[rowIndex,fieldIndex] = fields[fieldIndex];
		}
	}
	return returnArr;
}

private static void InsertTableData(string path, int tableID) {
	// Invokes method to read file and store data in string array of [rows][fields]
	string[,] data = ParseFile(path);
	
	using(SqlConnection connection = new SqlConnection(_connectionString)) {
		
		// Switch statement branches depending on table being inserted into.
		switch(tableID) {
		case 1:
		
			// Create new command string for inserting into Movie.Movies table.
			string commandString =
				"INSERT INTO Movie.Movies
				(Title,MPAARatingID,Runtime,ReleaseDate,Description,Country,Revenue)
				VALUES
				(@title,@MPAARatingID,@runtime,@releaseDate,@description,@country,@revenue)
			";
			
			// Execute the insert command once per row, using the values from that row.
			connection.Open();
			foreach(string[] row in data) {
				using(SqlCommand command = new SqlCommand(commandString, connection) {
				command.Parameters.AddWithValue("@title",row[0]);
				command.Parameters.AddWithValue("@MPAARatingID",row[1]);
				command.Parameters.AddWithValue("@runtime",row[2]);
				command.Parameters.AddWithValue("@releaseDate",row[3]);
				command.Parameters.AddWithValue("@description",row[4]);
				command.Parameters.AddWithValue("@country",row[5]);
				command.Parameters.AddWithValue("@revenue",row[6]);
				
				command.ExecuteNonQuery();
				}
			}
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9:
			break;
		default:
			break;
		}
	}
}