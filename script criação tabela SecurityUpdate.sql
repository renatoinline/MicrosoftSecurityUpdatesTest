/*

public string Id { get; set; }
public string Alias { get; set; }
public string DocumentTitle { get; set; }
public string Severity { get; set; }
public DateTime InitialReleaseDate { get; set; }
public DateTime CurrentReleaseDate { get; set; }
public string CvrfUrl { get; set; }

*/

CREATE TABLE SecurityUpdates(
	Id varchar(20) CONSTRAINT pk_SecurityUpdate PRIMARY key,
	Alias varchar(20) NOT null,
	DocumentTitle varchar(50) NOT null,
	Severity varchar(50) null,
	InitialReleaseDate datetime,
	CurrentReleaseDate datetime,
	CvrfUrl varchar(100)
)