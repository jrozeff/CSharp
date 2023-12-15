using sp19Homework5Example.Models;
using sp19Homework5Example.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace sp19Homework5Example.Seeding
{
	public static class SeedBooks
	{
		public static void SeedAllBooks(AppDbContext db)
		{
			if (db.Books.Count() == 250)
			{
				throw new NotSupportedException("The database already contains all 250 books!");
			}

			Int32 intBooksAdded = 0;
			String strBookTitle = "Begin"; //helps to keep track of error on books
			List<Book> Books = new List<Book>();

			try
			{
				Book b1 = new Book()
				{
					Title = "The Art Of Racing In The Rain",
					Author = "Garth Stein",
					Description = "A Lab-terrier mix with great insight into the human condition helps his owner, a struggling race car driver.",
					ReleaseDate = new DateTime(2008, 5, 24),
					Price = 23.95m
				};
				b1.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b1);

				Book b2 = new Book()
				{
					Title = "The Last Child",
					Author = "John Hart",
					Description = "A teenager searches for his inexplicably vanished twin sister.",
					ReleaseDate = new DateTime(2009, 5, 16),
					Price = 24.95m
				};
				b2.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b2);

				Book b3 = new Book()
				{
					Title = "Shanghai Girls",
					Author = "Lisa See",
					Description = "Two Chinese sisters in the 1930s are sold as wives to men from California, and leave their war-torn country to join them.",
					ReleaseDate = new DateTime(2009, 5, 30),
					Price = 25m
				};
				b3.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b3);

				Book b4 = new Book()
				{
					Title = "Skin Trade",
					Author = "Laurell K Hamilton",
					Description = "Investigating some killings in Las Vegas, the vampire hunter Anita Blake must contend with the power of the weretigers.",
					ReleaseDate = new DateTime(2009, 6, 6),
					Price = 26.95m
				};
				b4.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b4);

				Book b5 = new Book()
				{
					Title = "Roadside Crosses",
					Author = "Jeffery Deaver",
					Description = "A California kinesics expert pursues a killer who stalks victims using information they’ve posted online.",
					ReleaseDate = new DateTime(2009, 6, 13),
					Price = 26.95m
				};
				b5.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b5);

				Book b6 = new Book()
				{
					Title = "Return To Sullivans Island",
					Author = "Dorothea Benton Frank",
					Description = "A recent college graduate returns to her family’s home on an island in the South Carolina Lowcountry and wrestles with tragedy and betrayal in the company of her appealing relatives.",
					ReleaseDate = new DateTime(2009, 7, 4),
					Price = 25.99m
				};
				b6.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b6);

				Book b7 = new Book()
				{
					Title = "The Castaways",
					Author = "Elin Hilderbrand",
					Description = "A Nantucket couple drowns, raising questions and precipitating conflicts among their group of friends.",
					ReleaseDate = new DateTime(2009, 7, 11),
					Price = 24.99m
				};
				b7.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b7);

				Book b8 = new Book()
				{
					Title = "Rain Gods",
					Author = "James Lee Burke",
					Description = "A Texas sheriff investigates a mass murder of illegal aliens and tries to find the young Iraq war veteran who may have been involved — before the F.B.I. can.",
					ReleaseDate = new DateTime(2009, 7, 18),
					Price = 25.99m
				};
				b8.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b8);

				Book b9 = new Book()
				{
					Title = "Undone",
					Author = "Karin Slaughter",
					Description = "Dr. Sara Linton works with agents of the Georgia Bureau of Investigation to stop a killer who tortures his victims.",
					ReleaseDate = new DateTime(2009, 7, 18),
					Price = 26m
				};
				b9.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b9);

				Book b10 = new Book()
				{
					Title = "Guardian Of Lies",
					Author = "Steve Martini",
					Description = "The lawyer Paul Madriani unravels a mystery involving gold coins, the C.I.A., and a weapon forgotten since the Cuban missile crisis.",
					ReleaseDate = new DateTime(2009, 7, 18),
					Price = 26.99m
				};
				b10.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b10);

				Book b11 = new Book()
				{
					Title = "Dreamfever",
					Author = "Karen Marie Moning",
					Description = "MacKlaya finds herself under the erotic spell of a Fae master.",
					ReleaseDate = new DateTime(2009, 8, 22),
					Price = 26m
				};
				b11.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b11);

				Book b12 = new Book()
				{
					Title = "Resurrecting Midnight",
					Author = "Eric Jerome Dickey",
					Description = "Gideon, an international assassin, travels to Argentina in pursuit of a dangerous assignment.",
					ReleaseDate = new DateTime(2009, 8, 29),
					Price = 26.95m
				};
				b12.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b12);

				Book b13 = new Book()
				{
					Title = "Dexter By Design",
					Author = "Jeff Lindsay",
					Description = "A serial killer who arranges victims in artful poses challenges the Miami Police Department and its blood splatter analyst, Dexter.",
					ReleaseDate = new DateTime(2009, 9, 12),
					Price = 25m
				};
				b13.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b13);

				Book b14 = new Book()
				{
					Title = "The Professional",
					Author = "Robert B Parker",
					Description = "Rich women are turning up dead, and the Boston P.I. Spenser investigates.",
					ReleaseDate = new DateTime(2009, 10, 10),
					Price = 26.95m
				};
				b14.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b14);

				Book b15 = new Book()
				{
					Title = "The Unseen Academicals",
					Author = "Terry Pratchett",
					Description = "In this Discworld fantasy, the benevolent tyrant of Ankh-Morpork suggests that Unseen University put together a football team.",
					ReleaseDate = new DateTime(2009, 10, 10),
					Price = 25.99m
				};
				b15.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b15);

				Book b16 = new Book()
				{
					Title = "Pursuit Of Honor",
					Author = "Vince Flynn",
					Description = "The counterterrorism operative Mitch Rapp must teach politicians about national security following a new Qaeda attack.",
					ReleaseDate = new DateTime(2009, 10, 17),
					Price = 27.99m
				};
				b16.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b16);

				Book b17 = new Book()
				{
					Title = "No Less Than Victory",
					Author = "Jeff Shaara",
					Description = "The final volume of a trilogy of novels about World War II focuses on the final years of the war, including the Battle of the Bulge and the American sweep through Germany.",
					ReleaseDate = new DateTime(2009, 11, 7),
					Price = 28m
				};
				b17.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b17);

				Book b18 = new Book()
				{
					Title = "Ford County",
					Author = "John Grisham",
					Description = "Stories set in rural Mississippi.",
					ReleaseDate = new DateTime(2009, 11, 7),
					Price = 24m
				};
				b18.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b18);

				Book b19 = new Book()
				{
					Title = "Wishin' And Hopin'",
					Author = "Wally Lamb",
					Description = "A fifth-grader in 1964 gets ready for Christmas.",
					ReleaseDate = new DateTime(2009, 11, 14),
					Price = 15m
				};
				b19.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
				Books.Add(b19);

				Book b20 = new Book()
				{
					Title = "First Lord’S Fury",
					Author = "Jim Butcher",
					Description = "With their survival at stake, Alerans prepare for a final battle in the sixth book of the Alera fantasy cycle.",
					ReleaseDate = new DateTime(2009, 11, 28),
					Price = 25.95m
				};
				b20.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b20);

				Book b21 = new Book()
				{
					Title = "Altar Of Eden",
					Author = "James Rollins",
					Description = "A Louisiana veterinarian discovers a wrecked fishing trawler filled with genetically altered animals.",
					ReleaseDate = new DateTime(2010, 1, 2),
					Price = 27.99m
				};
				b21.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b21);

				Book b22 = new Book()
				{
					Title = "Deeper Than The Dead",
					Author = "Tami Hoag",
					Description = "An F.B.I. investigator and a teacher track a series of murders in California in 1985.",
					ReleaseDate = new DateTime(2010, 1, 2),
					Price = 26.95m
				};
				b22.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b22);

				Book b23 = new Book()
				{
					Title = "Roses",
					Author = "Leila Meacham",
					Description = "Three generations in a small East Texas town.",
					ReleaseDate = new DateTime(2010, 1, 16),
					Price = 24.99m
				};
				b23.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b23);

				Book b24 = new Book()
				{
					Title = "Blood Ties",
					Author = "Kay Hooper",
					Description = "The F.B.I. agent Noah Bishop and his special crimes unit  pursue a brutal enemy.",
					ReleaseDate = new DateTime(2010, 1, 30),
					Price = 26m
				};
				b24.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b24);

				Book b25 = new Book()
				{
					Title = "The Midnight House",
					Author = "Alex Berenson",
					Description = "Who is killing members of a secret unit that interrogated terrorists? The C.I.A. agent John Wells is on the case.",
					ReleaseDate = new DateTime(2010, 2, 13),
					Price = 25.95m
				};
				b25.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b25);

				Book b26 = new Book()
				{
					Title = "Deep Shadow",
					Author = "Randy Wayne White",
					Description = "Murderers want Doc Ford to help them dive for the remains of a wrecked plane supposedly laden with Cuban gold.",
					ReleaseDate = new DateTime(2010, 3, 13),
					Price = 25.95m
				};
				b26.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b26);

				Book b27 = new Book()
				{
					Title = "Think Twice",
					Author = "Lisa Scottoline",
					Description = "A woman takes over her twin sister’s life.",
					ReleaseDate = new DateTime(2010, 3, 20),
					Price = 26.99m
				};
				b27.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b27);

				Book b28 = new Book()
				{
					Title = "The Girl Who Chased The Moon",
					Author = "Sarah Addison Allen",
					Description = "Mysteries and magic in a quirky North Carolina town.",
					ReleaseDate = new DateTime(2010, 3, 20),
					Price = 25m
				};
				b28.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b28);

				Book b29 = new Book()
				{
					Title = "Without Mercy",
					Author = "Lisa Jackson",
					Description = "Students are dying at an Oregon boarding school for wayward kids, and the concerned new teacher may be the next target.",
					ReleaseDate = new DateTime(2010, 4, 3),
					Price = 25m
				};
				b29.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b29);

				Book b30 = new Book()
				{
					Title = "Wrecked",
					Author = "Carol Higgins Clark",
					Description = "In the 13th mystery in this series, the suspicious disappearance of a neighbor interrupts a romantic weekend on Cape Cod for the P.I. Regan Reilly and her husband.",
					ReleaseDate = new DateTime(2010, 4, 17),
					Price = 25m
				};
				b30.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b30);

				Book b31 = new Book()
				{
					Title = "Reckless",
					Author = "Andrew Gross",
					Description = "A close friend from the investigator Ty Hauck's past has been brutally murdered, and he will risk everything he loves to avenge her death.",
					ReleaseDate = new DateTime(2010, 5, 1),
					Price = 22m
				};
				b31.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b31);

				Book b32 = new Book()
				{
					Title = "Executive Intent",
					Author = "Dale Brown",
					Description = "With the United States unleashing a missile-launching satellite that can strike anywhere in seconds, China and Russia respond swiftly and brutally.",
					ReleaseDate = new DateTime(2010, 5, 15),
					Price = 27.95m
				};
				b32.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b32);

				Book b33 = new Book()
				{
					Title = "Heart Of The Matter",
					Author = "Emily Giffin",
					Description = "The lives of two women — one married to a pediatric plastic surgeon, the other a lawyer and single mother — converge after an accident involving the lawyer’s son.",
					ReleaseDate = new DateTime(2010, 5, 15),
					Price = 26.99m
				};
				b33.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b33);

				Book b34 = new Book()
				{
					Title = "That Perfect Someone",
					Author = "Johanna Lindsey",
					Description = "To avoid falling into a ruthless nobleman's trap, an heiress enters into a risky, intimate charade with a man she was once bound to wed.",
					ReleaseDate = new DateTime(2010, 6, 19),
					Price = 25m
				};
				b34.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b34);

				Book b35 = new Book()
				{
					Title = "Mission Of Honor",
					Author = "David Weber",
					Description = "Honor Harrington defends the Star Kingdom of Manticore as it is besieged by many enemies.",
					ReleaseDate = new DateTime(2010, 6, 26),
					Price = 27m
				};
				b35.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b35);

				Book b36 = new Book()
				{
					Title = "Sizzling Sixteen",
					Author = "Janet Evanovich",
					Description = "The bounty hunter Stephanie Plum comes to the aid of a cousin with gambling debts.",
					ReleaseDate = new DateTime(2010, 6, 26),
					Price = 27.99m
				};
				b36.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b36);

				Book b37 = new Book()
				{
					Title = "The Thousand Autumns Of Jacob De Zoet",
					Author = "David Mitchell",
					Description = "Forbidden love in Edo-era Japan.",
					ReleaseDate = new DateTime(2010, 7, 3),
					Price = 26m
				};
				b37.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b37);

				Book b38 = new Book()
				{
					Title = "The Search",
					Author = "Nora Roberts",
					Description = "The only survivor of a serial killer has found peace in the Pacific Northwest, but her life is shaken by the appearance of a new man and a copycat murderer.",
					ReleaseDate = new DateTime(2010, 7, 10),
					Price = 26.95m
				};
				b38.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b38);

				Book b39 = new Book()
				{
					Title = "Death On The D-List",
					Author = "Nancy Grace",
					Description = "Fading celebrities who appear on Hailey Dean’s TV show are being murdered.",
					ReleaseDate = new DateTime(2010, 8, 14),
					Price = 25.99m
				};
				b39.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b39);

				Book b40 = new Book()
				{
					Title = "No Mercy",
					Author = "Sherrilyn Kenyon",
					Description = "Book 19 of the Dark-Hunter paranormal series.",
					ReleaseDate = new DateTime(2010, 9, 11),
					Price = 24.99m
				};
				b40.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b40);

				Book b41 = new Book()
				{
					Title = "The Fall",
					Author = "Guillermo del Toro and Chuck Hogan",
					Description = "A war erupts between Old and New World vampires. Book 2 of the Strain trilogy.",
					ReleaseDate = new DateTime(2010, 9, 25),
					Price = 26.99m
				};
				b41.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b41);

				Book b42 = new Book()
				{
					Title = "Legacy",
					Author = "Danielle Steel",
					Description = "A writer’s stunning family discovery leads to Paris, the French aristocracy and a mysterious Sioux ancestor.",
					ReleaseDate = new DateTime(2010, 10, 2),
					Price = 28m
				};
				b42.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b42);

				Book b43 = new Book()
				{
					Title = "Call Me Mrs. Miracle",
					Author = "Debbie Macomber",
					Description = "Working in the toy section of a department store, Emily Merkle is called upon to engineer some Christmas miracles.",
					ReleaseDate = new DateTime(2010, 10, 2),
					Price = 16.95m
				};
				b43.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b43);

				Book b44 = new Book()
				{
					Title = "Promise Me",
					Author = "Richard Paul Evans",
					Description = "On Christmas Day, a woman with family problems meets a handsome, mysterious stranger.",
					ReleaseDate = new DateTime(2010, 10, 9),
					Price = 19.99m
				};
				b44.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b44);

				Book b45 = new Book()
				{
					Title = "Crescent Dawn",
					Author = "Clive Cussler and Dirk Cussler",
					Description = "Dirk Pitt seeks a tie between a trove of ancient Roman artifacts and a series of mosque explosions.",
					ReleaseDate = new DateTime(2010, 11, 20),
					Price = 27.95m
				};
				b45.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure");
				Books.Add(b45);

				Book b46 = new Book()
				{
					Title = "An Object Of Beauty",
					Author = "Steve Martin",
					Description = "A young, beautiful and ambitious woman ruthlessly ascends the heights of the Manhattan art world.",
					ReleaseDate = new DateTime(2010, 11, 27),
					Price = 26.99m
				};
				b46.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b46);

				Book b47 = new Book()
				{
					Title = "Dead Or Alive",
					Author = "Tom Clancy with Grant Blackwood",
					Description = "Many characters from Clancy’s previous novels make an appearance as an intelligence group tracks a vicious terrorist called the Emir.",
					ReleaseDate = new DateTime(2010, 12, 11),
					Price = 28.95m
				};
				b47.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b47);

				Book b48 = new Book()
				{
					Title = "Damage",
					Author = "John Lescroart",
					Description = "The San Francisco detective Abe Glitsky faces a scion of wealth who’s seeking revenge against those who sent him to prison a decade ago.",
					ReleaseDate = new DateTime(2011, 1, 8),
					Price = 26.95m
				};
				b48.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b48);

				Book b49 = new Book()
				{
					Title = "The Inner Circle",
					Author = "Brad Meltzer",
					Description = "An archivist discovers a book that once belonged to George Washington and conceals a deadly secret.",
					ReleaseDate = new DateTime(2011, 1, 15),
					Price = 26.99m
				};
				b49.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b49);

				Book b50 = new Book()
				{
					Title = "Shadowfever",
					Author = "Karen Marie Moning",
					Description = "Hunting for her sister’s murderer, MacKayla Lane is caught up in the struggle between humans and the Fae.",
					ReleaseDate = new DateTime(2011, 1, 22),
					Price = 26m
				};
				b50.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b50);

				Book b51 = new Book()
				{
					Title = "Call Me Irresistible",
					Author = "Susan Elizabeth Phillips",
					Description = "In a small town in Texas, characters from Phillips’s earlier novels reappear as a woman persuades a friend to call off her wedding to the town’s popular mayor.",
					ReleaseDate = new DateTime(2011, 1, 22),
					Price = 25.99m
				};
				b51.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b51);

				Book b52 = new Book()
				{
					Title = "A Discovery Of Witches",
					Author = "Deborah Harkness",
					Description = "The recovery of a lost ancient manuscript in a library at Oxford sets a fantastical underworld stirring.",
					ReleaseDate = new DateTime(2011, 2, 12),
					Price = 28.95m
				};
				b52.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b52);

				Book b53 = new Book()
				{
					Title = "Gideon’s Sword",
					Author = "Douglas Preston and Lincoln Child",
					Description = "Gideon Crew avenges his father’s death and is sent on a mission by a government contractor.",
					ReleaseDate = new DateTime(2011, 2, 26),
					Price = 26.99m
				};
				b53.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b53);

				Book b54 = new Book()
				{
					Title = "Treachery In Death",
					Author = "J D Robb",
					Description = "Eve Dallas and her partner, Peabody, investigate a grocer’s murder.",
					ReleaseDate = new DateTime(2011, 2, 26),
					Price = 26.95m
				};
				b54.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b54);

				Book b55 = new Book()
				{
					Title = "Live Wire",
					Author = "Harlan Coben",
					Description = "Myron Bolitar’s search for a missing rock star leads to questions about his own missing brother.",
					ReleaseDate = new DateTime(2011, 3, 26),
					Price = 27.95m
				};
				b55.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b55);

				Book b56 = new Book()
				{
					Title = "A Lesson In Secrets",
					Author = "Jacqueline Winspear",
					Description = "In the summer of 1932, Maisie Dobbs’s first assignment for the British secret service takes her undercover to Cambridge as a professor.",
					ReleaseDate = new DateTime(2011, 3, 26),
					Price = 25.99m
				};
				b56.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b56);

				Book b57 = new Book()
				{
					Title = "Crunch Time",
					Author = "Diane Mott Davidson",
					Description = "The caterer and sleuth Goldy Schulz tries to help a friend whose rental house has been destroyed by arson.",
					ReleaseDate = new DateTime(2011, 4, 9),
					Price = 26.99m
				};
				b57.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b57);

				Book b58 = new Book()
				{
					Title = "I’Ll Walk Alone",
					Author = "Mary Higgins Clark",
					Description = "A woman haunted by the disappearance of her young son discovers that someone has stolen her identity.",
					ReleaseDate = new DateTime(2011, 4, 9),
					Price = 25.99m
				};
				b58.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b58);

				Book b59 = new Book()
				{
					Title = "The Fifth Witness",
					Author = "Michael Connelly",
					Description = "The defense lawyer Mickey Haller represents a woman facing home foreclosure who is accused of killing a banker.",
					ReleaseDate = new DateTime(2011, 4, 9),
					Price = 27.99m
				};
				b59.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b59);

				Book b60 = new Book()
				{
					Title = "Save Me",
					Author = "Lisa Scottoline",
					Description = "A mother’s action during a school emergency causes an uproar in a Philadelphia suburb.",
					ReleaseDate = new DateTime(2011, 4, 16),
					Price = 27.99m
				};
				b60.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b60);

				Book b61 = new Book()
				{
					Title = "The Sixth Man",
					Author = "David Baldacci",
					Description = "The lawyer for an alleged serial killer is murdered, and two former Secret Service agents are on the case.",
					ReleaseDate = new DateTime(2011, 4, 23),
					Price = 27.99m
				};
				b61.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b61);

				Book b62 = new Book()
				{
					Title = "Those In Peril",
					Author = "Wilbur Smith",
					Description = "A private security agent battles pirates who have kidnapped a woman from a yacht in the Indian Ocean.",
					ReleaseDate = new DateTime(2011, 5, 14),
					Price = 27.99m
				};
				b62.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b62);

				Book b63 = new Book()
				{
					Title = "The Jefferson Key",
					Author = "Steve Berry",
					Description = "The former government operative Cotton Malone foils an assassination attempt on the president and finds himself at dangerous odds with a secret society.",
					ReleaseDate = new DateTime(2011, 5, 21),
					Price = 26m
				};
				b63.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b63);

				Book b64 = new Book()
				{
					Title = "Summer Rental",
					Author = "Mary Kay Andrews",
					Description = "Three friends in their mid-30s spend a month on North Carolina’s Outer Banks.",
					ReleaseDate = new DateTime(2011, 6, 11),
					Price = 25.99m
				};
				b64.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b64);

				Book b65 = new Book()
				{
					Title = "One Summer",
					Author = "David Baldacci",
					Description = "As Christmas nears, a terminally ill man is preparing his family for his death when another tragedy strikes.",
					ReleaseDate = new DateTime(2011, 6, 18),
					Price = 25.99m
				};
				b65.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b65);

				Book b66 = new Book()
				{
					Title = "Before I Go To Sleep",
					Author = "S J Watson",
					Description = "After a mysterious accident, an amnesiac cannot remember her past or form new memories.",
					ReleaseDate = new DateTime(2011, 6, 18),
					Price = 14.99m
				};
				b66.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b66);

				Book b67 = new Book()
				{
					Title = "Now You See Her",
					Author = "James Patterson and Michael Ledwidge",
					Description = "Nina Bloom, who years ago changed her identity to save her life, is forced to confront the past and the killer she thought she had escaped.",
					ReleaseDate = new DateTime(2011, 7, 2),
					Price = 27.99m
				};
				b67.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b67);

				Book b68 = new Book()
				{
					Title = "Full Black",
					Author = "Brad Thor",
					Description = "The covert counterterrorism operative Scot Harvath has a plan to stop a terrorist group that wants to take down the United States.",
					ReleaseDate = new DateTime(2011, 7, 30),
					Price = 26.99m
				};
				b68.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b68);

				Book b69 = new Book()
				{
					Title = "Ghost Story",
					Author = "Jim Butcher",
					Description = "Harry Dresden, the wizard detective in Chicago, has been murdered. But that doesn’t stop him when his friends are in danger.",
					ReleaseDate = new DateTime(2011, 7, 30),
					Price = 27.95m
				};
				b69.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b69);

				Book b70 = new Book()
				{
					Title = "Back Of Beyond",
					Author = "C J Box",
					Description = "Cody Hoyt, a brilliant cop and an alcoholic struggling with two months of sobriety, is determined to find his mentor’s killer.",
					ReleaseDate = new DateTime(2011, 8, 6),
					Price = 25.99m
				};
				b70.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b70);

				Book b71 = new Book()
				{
					Title = "The Omen Machine",
					Author = "Terry Goodkind",
					Description = "A return to the lives of Richard Rahl and Kahlan Amnell, in a tale of a new threat to their world.",
					ReleaseDate = new DateTime(2011, 8, 20),
					Price = 29.99m
				};
				b71.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b71);

				Book b72 = new Book()
				{
					Title = "The Measure Of The Magic",
					Author = "Terry Brooks",
					Description = "With the land on edge, Panterra is destined to confront a menace who seeks to claim the last black staff, and the life of the one who wields it.",
					ReleaseDate = new DateTime(2011, 8, 27),
					Price = 27m
				};
				b72.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b72);

				Book b73 = new Book()
				{
					Title = "How Firm A Foundation",
					Author = "David Weber",
					Description = "The island empire of Charis fights to survive.",
					ReleaseDate = new DateTime(2011, 9, 17),
					Price = 27.99m
				};
				b73.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b73);

				Book b74 = new Book()
				{
					Title = "Reamde",
					Author = "Neal Stephenson",
					Description = "A virus invades a multiplayer online role-playing game and sets off a violent struggle.",
					ReleaseDate = new DateTime(2011, 9, 24),
					Price = 35m
				};
				b74.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b74);

				Book b75 = new Book()
				{
					Title = "Nightwoods",
					Author = "Charles Frazier",
					Description = "When a young woman inherits her murdered sister’s troubled twins, her solitary life becomes filled with mystery and action.",
					ReleaseDate = new DateTime(2011, 10, 1),
					Price = 26m
				};
				b75.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b75);

				Book b76 = new Book()
				{
					Title = "The Affair",
					Author = "Lee Child",
					Description = "For Jack Reacher, an elite military police officer, it all started in 1997. A lonely railroad track. A crime scene. A cover-up.",
					ReleaseDate = new DateTime(2011, 10, 1),
					Price = 28m
				};
				b76.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b76);

				Book b77 = new Book()
				{
					Title = "A Lawman's Christmas",
					Author = "Linda Lael Miller",
					Description = "The death of the town marshal leaves Blue River, Texas, without a lawman, and Dara Rose Nolan without a husband. Clay McKettrick steps in, and when he and Dara Rose agree to a marriage of convenience, the temporary lawman’s Christmas wish is to make her his permanent wife.",
					ReleaseDate = new DateTime(2011, 10, 1),
					Price = 28m
				};
				b77.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b77);

				Book b78 = new Book()
				{
					Title = "Bonnie",
					Author = "Iris Johansen",
					Description = "The forensic sculptor Eve Duncan learns more about her daughter’s disappearance and the girl’s father‘s possible involvement.",
					ReleaseDate = new DateTime(2011, 10, 22),
					Price = 27.99m
				};
				b78.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b78);

				Book b79 = new Book()
				{
					Title = "Zero Day",
					Author = "David Baldacci",
					Description = "A military investigator uncovers a conspiracy.",
					ReleaseDate = new DateTime(2011, 11, 5),
					Price = 27.99m
				};
				b79.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b79);

				Book b80 = new Book()
				{
					Title = "The Scottish Prisoner",
					Author = "Diana Gabaldon",
					Description = "Jamie Fraser, a paroled Jacobite prisoner, and Lord John Grey collaborate uneasily on a mission to Ireland.",
					ReleaseDate = new DateTime(2011, 12, 3),
					Price = 28m
				};
				b80.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b80);

				Book b81 = new Book()
				{
					Title = "The Hunter",
					Author = "John Lescroart",
					Description = "A San Francisco private investigator discovers chilling facts about his birth family.",
					ReleaseDate = new DateTime(2012, 1, 7),
					Price = 26.95m
				};
				b81.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b81);

				Book b82 = new Book()
				{
					Title = "Copper Beach",
					Author = "Jayne Ann Krentz",
					Description = "Amy Radwell, whose psychic talent enables her to understand the paranormal secrets in rare books, becomes the target of a blackmailer. The first book in a new series about rare books and psychic codes.",
					ReleaseDate = new DateTime(2012, 1, 14),
					Price = 25.95m
				};
				b82.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b82);

				Book b83 = new Book()
				{
					Title = "Left For Dead",
					Author = "J A Jance",
					Description = "Ali Reynolds seeks justice for an old friend and an unidentified woman, both victims of brutal attacks.",
					ReleaseDate = new DateTime(2012, 2, 11),
					Price = 25.99m
				};
				b83.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b83);

				Book b84 = new Book()
				{
					Title = "Robert Ludlum’S The Janson Command",
					Author = "Paul Garrison",
					Description = "A former American operative builds a network to help him resolve crises without torture or civilian casualties.",
					ReleaseDate = new DateTime(2012, 2, 18),
					Price = 27.99m
				};
				b84.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b84);

				Book b85 = new Book()
				{
					Title = "Victims",
					Author = "Jonathan Kellerman",
					Description = "The Los Angeles psychologist-detective Alex Delaware and the detective Milo Sturgis track down a homicidal maniac.",
					ReleaseDate = new DateTime(2012, 3, 3),
					Price = 28m
				};
				b85.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b85);

				Book b86 = new Book()
				{
					Title = "Another Piece Of My Heart",
					Author = "Jane Green",
					Description = "A woman in her late 30s marries the man of her dreams and reaches out to his daughters by his previous marriage, but one of them is determined to destroy her.",
					ReleaseDate = new DateTime(2012, 3, 17),
					Price = 25.99m
				};
				b86.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b86);

				Book b87 = new Book()
				{
					Title = "Unnatural Acts",
					Author = "Stuart Woods",
					Description = "The New York lawyer Stone Barrington becomes involved in the family problems of a billionaire hedge fund manager.",
					ReleaseDate = new DateTime(2012, 4, 21),
					Price = 26.95m
				};
				b87.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b87);

				Book b88 = new Book()
				{
					Title = "Mission To Paris",
					Author = "Alan Furst",
					Description = "In Paris in 1938, an actor stumbles into the clutches of Nazi conspirators who want to exploit his celebrity.",
					ReleaseDate = new DateTime(2012, 6, 16),
					Price = 27m
				};
				b88.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b88);

				Book b89 = new Book()
				{
					Title = "Shadow Of Night",
					Author = "Deborah Harkness",
					Description = "An Oxford scholar/witch and a vampire geneticist pursue history, secrets and each other in Elizabethan London.",
					ReleaseDate = new DateTime(2012, 7, 14),
					Price = 28.95m
				};
				b89.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b89);

				Book b90 = new Book()
				{
					Title = "Where We Belong",
					Author = "Emily Giffin",
					Description = "A woman’s successful life is disrupted by the appearance of an 18-year-old girl with a link to her past.",
					ReleaseDate = new DateTime(2012, 7, 28),
					Price = 27.99m
				};
				b90.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b90);

				Book b91 = new Book()
				{
					Title = "Judgment Call",
					Author = "J A Jance",
					Description = "Joanna Brady, an Arizona sheriff, must function as both a law officer and a mother when her daughter’s high school principal is murdered.",
					ReleaseDate = new DateTime(2012, 7, 28),
					Price = 25.99m
				};
				b91.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b91);

				Book b92 = new Book()
				{
					Title = "Broken Harbor",
					Author = "Tana French",
					Description = "In French’s fourth Dublin murder squad novel, a detective’s investigation of a crime in a seaside town evokes memories of his disturbing childhood there.",
					ReleaseDate = new DateTime(2012, 7, 28),
					Price = 27.95m
				};
				b92.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b92);

				Book b93 = new Book()
				{
					Title = "Odd Apocalypse",
					Author = "Dean Koontz",
					Description = "Odd Thomas, who can communicate with the dead, explores the mysteries of an old estate now owned by a billionaire.",
					ReleaseDate = new DateTime(2012, 8, 4),
					Price = 28m
				};
				b93.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
				Books.Add(b93);

				Book b94 = new Book()
				{
					Title = "Haven",
					Author = "Kay Hooper",
					Description = "The F.B.I. agent Noah Bishop and his special crimes unit help two sisters probe the secrets of a North Carolina town.",
					ReleaseDate = new DateTime(2012, 8, 4),
					Price = 26.95m
				};
				b94.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b94);

				Book b95 = new Book()
				{
					Title = "The Inn At Rose Harbor",
					Author = "Debbie Macomber",
					Description = "A young widow buys a bed-and-breakfast.",
					ReleaseDate = new DateTime(2012, 8, 18),
					Price = 26m
				};
				b95.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b95);

				Book b96 = new Book()
				{
					Title = "Wards Of Faerie",
					Author = "Terry Brooks",
					Description = "In the first book of a new fantasy series, the Dark Legacy of Shannara, Druids, Elves and humans unite to try to capture the Elfstones and rescue the troubled Four Lands.",
					ReleaseDate = new DateTime(2012, 8, 25),
					Price = 28m
				};
				b96.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b96);

				Book b97 = new Book()
				{
					Title = "A Sunless Sea",
					Author = "Anne Perry",
					Description = "A murder case for William Monk of the Thames River Police culminates in a government minister’s corruption trial.",
					ReleaseDate = new DateTime(2012, 9, 1),
					Price = 26m
				};
				b97.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b97);

				Book b98 = new Book()
				{
					Title = "Last To Die",
					Author = "Tess Gerritsen",
					Description = "The detective Jane Rizzoli and the medical examiner Maura Isles protect a boy whose family and foster family have all been murdered.",
					ReleaseDate = new DateTime(2012, 9, 1),
					Price = 27m
				};
				b98.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b98);

				Book b99 = new Book()
				{
					Title = "Telegraph Avenue",
					Author = "Michael Chabon",
					Description = "Fathers and sons in Berkeley and Oakland, Calif.",
					ReleaseDate = new DateTime(2012, 9, 15),
					Price = 27.99m
				};
				b99.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b99);

				Book b100 = new Book()
				{
					Title = "Midst Toil And Tribulation",
					Author = "David Weber",
					Description = "In Book 6 of the Safehold science fiction series, the republic of Siddamark descends into chaos.",
					ReleaseDate = new DateTime(2012, 9, 22),
					Price = 27.99m
				};
				b100.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b100);

				Book b101 = new Book()
				{
					Title = "Sleep No More",
					Author = "Iris Johansen",
					Description = "The forensic sculptor Eve Duncan investigates when her mother’s friend disappears from a mental hospital.",
					ReleaseDate = new DateTime(2012, 10, 20),
					Price = 27.99m
				};
				b101.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b101);

				Book b102 = new Book()
				{
					Title = "Sweet Tooth",
					Author = "Ian McEwan",
					Description = "A British woman working for MI5 in 1972 falls in love with a writer the service is clandestinely supporting.",
					ReleaseDate = new DateTime(2012, 11, 17),
					Price = 26.95m
				};
				b102.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b102);

				Book b103 = new Book()
				{
					Title = "Merry Christmas, Alex Cross",
					Author = "James Patterson",
					Description = "Detective Alex Cross confronts both a hostage situation and a terrorist act at Christmas.",
					ReleaseDate = new DateTime(2012, 11, 17),
					Price = 28.99m
				};
				b103.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b103);

				Book b104 = new Book()
				{
					Title = "Threat Vector",
					Author = "Tom Clancy with Mark Greaney",
					Description = "As China threatens to invade Taiwan, the covert intelligence expert Jack Ryan Jr. aids his father’s administration  — but his agency is no longer secret.",
					ReleaseDate = new DateTime(2012, 12, 8),
					Price = 28.95m
				};
				b104.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b104);

				Book b105 = new Book()
				{
					Title = "Two Graves",
					Author = "Douglas Preston and Lincoln Child",
					Description = "Special Agent Aloysius Pendergast pursues a serial killer as well as his abducted wife.",
					ReleaseDate = new DateTime(2012, 12, 15),
					Price = 26.99m
				};
				b105.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b105);

				Book b106 = new Book()
				{
					Title = "Collateral Damage",
					Author = "Stuart Woods",
					Description = "Back in New York, the lawyer Stone Barrington joins his former partner Holly Barker in pursuing a dangerous case.",
					ReleaseDate = new DateTime(2013, 1, 12),
					Price = 26.95m
				};
				b106.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b106);

				Book b107 = new Book()
				{
					Title = "Kinsey And Me",
					Author = "Sue Grafton",
					Description = "Stories about Grafton’s character Kinsey Millhone as well as explorations of Grafton’s own past.",
					ReleaseDate = new DateTime(2013, 1, 12),
					Price = 27.95m
				};
				b107.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b107);

				Book b108 = new Book()
				{
					Title = "The Third Bullet",
					Author = "Stephen Hunter",
					Description = "The veteran sniper Bob Lee Swagger investigates the assassination of John F. Kennedy. ",
					ReleaseDate = new DateTime(2013, 1, 19),
					Price = 26.99m
				};
				b108.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b108);

				Book b109 = new Book()
				{
					Title = "The Night Ranger",
					Author = "Alex Berenson",
					Description = "The former C.I.A. operative John Wells pitches in when four young Americans who work at a refugee camp in Somalia are hijacked by bandits. ",
					ReleaseDate = new DateTime(2013, 2, 16),
					Price = 27.95m
				};
				b109.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b109);

				Book b110 = new Book()
				{
					Title = "Sweet Tea Revenge",
					Author = "Laura Childs",
					Description = "Theodosia Browning, owner of Indigo Tea Shop, is a bridesmaid in her friend's wedding. But the bridegroom is found dead on the big day.",
					ReleaseDate = new DateTime(2013, 3, 9),
					Price = 29m
				};
				b110.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b110);

				Book b111 = new Book()
				{
					Title = "The Last Threshold",
					Author = "R A Salvatore",
					Description = "Book 4 of the fantasy Neverwinter Saga.",
					ReleaseDate = new DateTime(2013, 3, 9),
					Price = 27.95m
				};
				b111.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b111);

				Book b112 = new Book()
				{
					Title = "The Supremes At Earl's All-You-Can-Eat",
					Author = "Edward Kelsey Moore",
					Description = "Four decades in the friendship of three middle-class black women in a small  southern Indiana town.",
					ReleaseDate = new DateTime(2013, 3, 16),
					Price = 24.95m
				};
				b112.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
				Books.Add(b112);

				Book b113 = new Book()
				{
					Title = "Lover At Last",
					Author = "J R Ward",
					Description = "Book 11 of the Black Dagger Brotherhood series.",
					ReleaseDate = new DateTime(2013, 3, 30),
					Price = 27.95m
				};
				b113.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b113);

				Book b114 = new Book()
				{
					Title = "Leaving Everything Most Loved",
					Author = "Jacqueline Winspear",
					Description = "In 1933, the private investigator Maisie Dobbs helps an Indian man whose sister’s murder has been ignored by Scotland Yard.",
					ReleaseDate = new DateTime(2013, 3, 30),
					Price = 26.99m
				};
				b114.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b114);

				Book b115 = new Book()
				{
					Title = "All That Is",
					Author = "James Salter",
					Description = "A veteran makes a career in publishing in postwar New York and struggles to achieve romantic success.",
					ReleaseDate = new DateTime(2013, 4, 6),
					Price = 26.95m
				};
				b115.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b115);

				Book b116 = new Book()
				{
					Title = "Unintended Consequences",
					Author = "Stuart Woods",
					Description = "The New York lawyer Stone Barrington discovers a shadowy network beneath the world of European wealth.",
					ReleaseDate = new DateTime(2013, 4, 13),
					Price = 26.95m
				};
				b116.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b116);

				Book b117 = new Book()
				{
					Title = "Nos4A2",
					Author = "Joe Hill",
					Description = "In a creepy battle between real and imaginary worlds, a brave biker chick is pitted against a ghoulish villain who lures children to a place where it is always Christmas.",
					ReleaseDate = new DateTime(2013, 5, 4),
					Price = 34m
				};
				b117.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b117);

				Book b118 = new Book()
				{
					Title = "Zero Hour",
					Author = "Clive Cussler and Graham Brown",
					Description = "Kurt Austin, Joe Zavala and the rest of the Numa team search for a physicist's machine, buried in an ocean trench, that can cause deadly earthquakes in the 11th Numa Files novel.",
					ReleaseDate = new DateTime(2013, 6, 1),
					Price = 28.95m
				};
				b118.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b118);

				Book b119 = new Book()
				{
					Title = "The Son",
					Author = "Philipp Meyer",
					Description = "More than 150 years in a Texas family, from Comanche raids to the present, and its rise to money and power in the cattle and oil industries.",
					ReleaseDate = new DateTime(2013, 6, 1),
					Price = 22m
				};
				b119.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b119);

				Book b120 = new Book()
				{
					Title = "Red Sparrow",
					Author = "Jason Matthews",
					Description = "A Russian intelligence officer trained in the art of seduction becomes entangled with a young C.I.A. officer.",
					ReleaseDate = new DateTime(2013, 6, 8),
					Price = 26.95m
				};
				b120.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b120);

				Book b121 = new Book()
				{
					Title = "The Silver Star",
					Author = "Jeannette Walls",
					Description = "When their irresponsible mother takes off, a 12-year-old California girl and her sister join the rest of their family in Virginia. ",
					ReleaseDate = new DateTime(2013, 6, 15),
					Price = 23.95m
				};
				b121.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b121);

				Book b122 = new Book()
				{
					Title = "Sisterland",
					Author = "Curtis Sittenfeld",
					Description = "Twins with psychic abilities share a devastating secret.",
					ReleaseDate = new DateTime(2013, 6, 29),
					Price = 27.99m
				};
				b122.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b122);

				Book b123 = new Book()
				{
					Title = "The English Girl",
					Author = "Daniel Silva",
					Description = "Gabriel Allon, an art restorer and occasional spy for the Israeli secret service, steps in to help the British prime minister, whose lover has been kidnapped. ",
					ReleaseDate = new DateTime(2013, 7, 20),
					Price = 17.95m
				};
				b123.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b123);

				Book b124 = new Book()
				{
					Title = "Hunting Eve",
					Author = "Iris Johansen",
					Description = "In the second book of a trilogy, the forensic sculptor Eve Duncan struggles to outwit a kidnapper in the Colorado wilderness.",
					ReleaseDate = new DateTime(2013, 7, 20),
					Price = 35.99m
				};
				b124.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b124);

				Book b125 = new Book()
				{
					Title = "Light Of The World",
					Author = "James Lee Burke",
					Description = "A savage killer follows the detective Dave Robicheaux and his family to a Montana ranch. ",
					ReleaseDate = new DateTime(2013, 7, 27),
					Price = 32m
				};
				b125.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b125);

				Book b126 = new Book()
				{
					Title = "The Kill List",
					Author = "Frederick Forsyth",
					Description = "An Arabic-speaking Marine major known as the Tracker pursues a terrorist who radicalizes young Muslims living abroad.",
					ReleaseDate = new DateTime(2013, 8, 24),
					Price = 23.95m
				};
				b126.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b126);

				Book b127 = new Book()
				{
					Title = "Songs Of Willow Frost",
					Author = "Jamie Ford",
					Description = "A 12-year-old Seattle orphan during the Depression becomes convinced that a movie star is really his vanished mother. ",
					ReleaseDate = new DateTime(2013, 9, 14),
					Price = 18m
				};
				b127.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b127);

				Book b128 = new Book()
				{
					Title = "W Is For Wasted",
					Author = "Sue Grafton",
					Description = "A homeless man inexplicably leaves $600,000 to Kinsey Millhone.",
					ReleaseDate = new DateTime(2013, 9, 14),
					Price = 16m
				};
				b128.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b128);

				Book b129 = new Book()
				{
					Title = "Deadly Heat",
					Author = "Richard Castle",
					Description = "The N.Y.P.D. homicide detective Nikki Heat and the journalist Jameson Rook search for the former C.I.A. station chief who ordered her mother’s execution.\nThe N.Y.P.D. homicide detective Nikki Heat and the journalist Jameson Rook search for the former C.I.A. station chief who ordered her mother’s execution.",
					ReleaseDate = new DateTime(2013, 9, 21),
					Price = 16m
				};
				b129.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b129);

				Book b130 = new Book()
				{
					Title = "Deadline",
					Author = "Sandra Brown",
					Description = "A journalist who pursues a story about a former marine, the son of terrorists from 40 years ago,becomes a suspect in the death of his ex-wife.",
					ReleaseDate = new DateTime(2013, 9, 28),
					Price = 16m
				};
				b130.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b130);

				Book b131 = new Book()
				{
					Title = "Silencing Eve",
					Author = "Iris Johansen",
					Description = "The final book of a trilogy about the forensic sculptor Eve Duncan. ",
					ReleaseDate = new DateTime(2013, 10, 5),
					Price = 19m
				};
				b131.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b131);

				Book b132 = new Book()
				{
					Title = "Starry Night",
					Author = "Debbie Macomber",
					Description = "At Christmastime, a big-city columnist sets out to interview a reclusive author in Alaska. ",
					ReleaseDate = new DateTime(2013, 10, 12),
					Price = 24.95m
				};
				b132.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b132);

				Book b133 = new Book()
				{
					Title = "Bridget Jones: Mad About The Boy",
					Author = "Helen Fielding",
					Description = "Bridget, now 51 and a mother and widow, is once again looking for love.",
					ReleaseDate = new DateTime(2013, 10, 19),
					Price = 29.95m
				};
				b133.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b133);

				Book b134 = new Book()
				{
					Title = "The Last Dark",
					Author = "Stephen R Donaldson",
					Description = "The 10th and final installment of the sprawling fantasy series about Thomas Covenant the Unbeliever.",
					ReleaseDate = new DateTime(2013, 10, 19),
					Price = 16m
				};
				b134.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b134);

				Book b135 = new Book()
				{
					Title = "Aimless Love",
					Author = "Billy Collins",
					Description = "More than 50 new poems as well as selections from previous books from the two-term poet laureate of the Untied States.",
					ReleaseDate = new DateTime(2013, 10, 26),
					Price = 30.99m
				};
				b135.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Poetry");
				Books.Add(b135);

				Book b136 = new Book()
				{
					Title = "Tatiana",
					Author = "Martin Cruz Smith",
					Description = "A dead translator’s coded notebook may hold the key to the murders of a muckraking journalist and an oligarch in the former Soviet Union. Arkady Renko, a senior investigator in the Moscow prosecutor’s office, is on the case.",
					ReleaseDate = new DateTime(2013, 11, 16),
					Price = 20.99m
				};
				b136.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b136);

				Book b137 = new Book()
				{
					Title = "Dust",
					Author = "Patricia Cornwell",
					Description = "The murder of a computer engineer at M.I.T. leads the Massachusetts Chief Medical Examiner Kay Scarpetta in unexpected directions.",
					ReleaseDate = new DateTime(2013, 11, 16),
					Price = 23.99m
				};
				b137.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b137);

				Book b138 = new Book()
				{
					Title = "The Supreme Macaroni Company",
					Author = "Adriana Trigiani",
					Description = "Tensions arise when Valentine Roncalli, a Greenwich Village shoe designer, marries a handsome Italian, and the two must balance careers, countries and families. The final book in the Valentine trilogy. ",
					ReleaseDate = new DateTime(2013, 11, 30),
					Price = 34.99m
				};
				b138.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b138);

				Book b139 = new Book()
				{
					Title = "Innocence",
					Author = "Dean Koontz",
					Description = "A grotesque man living in exile beneath the city encounters a teenage girl hiding from dangerous enemies.",
					ReleaseDate = new DateTime(2013, 12, 14),
					Price = 21m
				};
				b139.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
				Books.Add(b139);

				Book b140 = new Book()
				{
					Title = "Hunting Shadows",
					Author = "Charles Todd",
					Description = "In the aftermath of World War I, a Scotland Yard detective with a heavy burden of guilt, investigates two murders in Cambridgeshire that may be linked.",
					ReleaseDate = new DateTime(2014, 1, 25),
					Price = 32.99m
				};
				b140.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b140);

				Book b141 = new Book()
				{
					Title = "Confessions Of A Wild Child",
					Author = "Jackie Collins",
					Description = "The early years of Collins’s recurring character Lucky Santangelo.",
					ReleaseDate = new DateTime(2014, 2, 8),
					Price = 30.95m
				};
				b141.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b141);

				Book b142 = new Book()
				{
					Title = "The Counterfeit Agent",
					Author = "Alex Berenson",
					Description = "John Wells is sent on a mission to find the truth about a mysterious Iranian package said to be bound for the United States.",
					ReleaseDate = new DateTime(2014, 2, 15),
					Price = 16.99m
				};
				b142.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b142);

				Book b143 = new Book()
				{
					Title = "Like A Mighty Army",
					Author = "David Weber",
					Description = "In Book 7 of the Safehold science fiction series, the empire of Charis fights for self-determination. ",
					ReleaseDate = new DateTime(2014, 2, 22),
					Price = 22m
				};
				b143.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b143);

				Book b144 = new Book()
				{
					Title = "Cavendon Hall",
					Author = "Barbara Taylor Bradford",
					Description = "In Edwardian England, an aristocratic family and the family who serve them share an ancestral home. ",
					ReleaseDate = new DateTime(2014, 4, 5),
					Price = 26m
				};
				b144.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b144);

				Book b145 = new Book()
				{
					Title = "Frog Music",
					Author = "Emma Donoghue",
					Description = "A murder mystery set in San Francisco in 1876, when the city is in the grip of a smallpox epidemic and a heat wave.",
					ReleaseDate = new DateTime(2014, 4, 5),
					Price = 16.95m
				};
				b145.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b145);

				Book b146 = new Book()
				{
					Title = "Destroyer Angel",
					Author = "Nevada Barr",
					Description = "The National Park Service Ranger Anna Pigeon must rescue friends who are kidnapped while camping in Minnesota.",
					ReleaseDate = new DateTime(2014, 4, 5),
					Price = 32m
				};
				b146.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b146);

				Book b147 = new Book()
				{
					Title = "Warriors",
					Author = "Ted Bell",
					Description = "The counterspy Alex Hawke must rescue a kidnapped scientist. ",
					ReleaseDate = new DateTime(2014, 4, 5),
					Price = 33.99m
				};
				b147.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b147);

				Book b148 = new Book()
				{
					Title = "Live To See Tomorrow",
					Author = "Iris Johansen",
					Description = "The C.I.A. operative Catherine Ling must spearhead the rescue of an American journalist kidnapped in Tibet. ",
					ReleaseDate = new DateTime(2014, 5, 3),
					Price = 34m
				};
				b148.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b148);

				Book b149 = new Book()
				{
					Title = "All The Light We Cannot See",
					Author = "Anthony Doerr",
					Description = "The lives of a blind French girl and a gadget-obsessed German boy before and during World War II, when their paths eventually cross. ",
					ReleaseDate = new DateTime(2014, 5, 10),
					Price = 23.95m
				};
				b149.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b149);

				Book b150 = new Book()
				{
					Title = "The Kraken Project",
					Author = "Douglas Preston",
					Description = "The former C.I.A. agent Wyman Ford must stop Dorothy, a powerful artificial intelligence that has gone rogue.",
					ReleaseDate = new DateTime(2014, 5, 17),
					Price = 35m
				};
				b150.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b150);

				Book b151 = new Book()
				{
					Title = "The Vacationers",
					Author = "Emma Straub",
					Description = "Well-heeled New Yorkers and their friends spend two weeks in Majorca, a time when rivalries and secrets come to light.",
					ReleaseDate = new DateTime(2014, 5, 31),
					Price = 33m
				};
				b151.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b151);

				Book b152 = new Book()
				{
					Title = "The Hurricane Sisters",
					Author = "Dorothea Benton Frank",
					Description = "Three generations of women endure a stormy summer in South Carolina's Lowcountry.",
					ReleaseDate = new DateTime(2014, 6, 7),
					Price = 16m
				};
				b152.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b152);

				Book b153 = new Book()
				{
					Title = "The Matchmaker",
					Author = "Elin Hilderbrand",
					Description = "A Nantucket resident’s life is shaken by a diagnosis and the return to the island of her high school sweetheart. ",
					ReleaseDate = new DateTime(2014, 6, 14),
					Price = 25m
				};
				b153.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b153);

				Book b154 = new Book()
				{
					Title = "Terminal City",
					Author = "Linda Fairstein",
					Description = "Alexandra Cooper, a Manhattan assistant district attorney, hunts for a killer in Grand Central’s underground tunnels.",
					ReleaseDate = new DateTime(2014, 6, 21),
					Price = 32.95m
				};
				b154.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b154);

				Book b155 = new Book()
				{
					Title = "Landline",
					Author = "Rainbow Rowell",
					Description = "A woman in a troubled marriage finds a way to communicate with her husband in the past. ",
					ReleaseDate = new DateTime(2014, 7, 12),
					Price = 29m
				};
				b155.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b155);

				Book b156 = new Book()
				{
					Title = "The Book Of Life",
					Author = "Deborah Harkness",
					Description = "In the conclusion to the All Souls trilogy, the Oxford scholar/witch Diana Bishop and the vampire geneticist Matthew Clairmont return from Elizabethan London to the present.",
					ReleaseDate = new DateTime(2014, 7, 19),
					Price = 27.95m
				};
				b156.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b156);

				Book b157 = new Book()
				{
					Title = "Magic Breaks",
					Author = "Ilona Andrews",
					Description = "In the seventh Kate Daniels novel, Kate deals with paranormal politics in Atlanta as she prepares the Pack for an attack.",
					ReleaseDate = new DateTime(2014, 8, 2),
					Price = 32m
				};
				b157.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b157);

				Book b158 = new Book()
				{
					Title = "Big Little Lies",
					Author = "Liane Moriarty",
					Description = "Who will end up dead, and how, when three mothers with children in the same school become friends?",
					ReleaseDate = new DateTime(2014, 8, 2),
					Price = 17m
				};
				b158.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b158);

				Book b159 = new Book()
				{
					Title = "Dark Skye",
					Author = "Kresley Cole",
					Description = "Will a scarred warrior and the beautiful sorceress with the power to heal him overcome the challenges of their warring families and the chaotic battles around them? Book 15 in the Immortals After Dark series.",
					ReleaseDate = new DateTime(2014, 8, 9),
					Price = 20m
				};
				b159.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b159);

				Book b160 = new Book()
				{
					Title = "The Magician's Land",
					Author = "Lev Grossman",
					Description = "Quentin, an exiled magician, tries a risky heist in the final installment of a trilogy.",
					ReleaseDate = new DateTime(2014, 8, 9),
					Price = 28.95m
				};
				b160.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b160);

				Book b161 = new Book()
				{
					Title = "Mean Streak",
					Author = "Sandra Brown",
					Description = "A North Carolina pediatrician is held captive by a mysterious man who forces her to question her life. ",
					ReleaseDate = new DateTime(2014, 8, 23),
					Price = 29.95m
				};
				b161.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b161);

				Book b162 = new Book()
				{
					Title = "The King's Curse",
					Author = "Philippa Gregory",
					Description = "As chief lady-in-waiting to Katherine of Aragon, Margaret Pole is torn between the queen and her husband, Henry VIII.",
					ReleaseDate = new DateTime(2014, 9, 13),
					Price = 18.99m
				};
				b162.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b162);

				Book b163 = new Book()
				{
					Title = "Bones Never Lie",
					Author = "Kathy Reichs",
					Description = "A child murderer who eluded capture years ago has resurfaced, giving the forensic anthropologist Temperance Brennan another chance to stop her.",
					ReleaseDate = new DateTime(2014, 9, 27),
					Price = 14.95m
				};
				b163.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b163);

				Book b164 = new Book()
				{
					Title = "Nora Webster",
					Author = "Colm Toibin",
					Description = "In the 1970s, an Irish widow struggles to find her identity.",
					ReleaseDate = new DateTime(2014, 10, 11),
					Price = 30.99m
				};
				b164.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b164);

				Book b165 = new Book()
				{
					Title = "Winter Street",
					Author = "Elin Hilderbrand",
					Description = "Complications ensue when the owner of Nantucket’s Winter Street Inn gathers his four children and their families for Christmas.",
					ReleaseDate = new DateTime(2014, 10, 18),
					Price = 20.95m
				};
				b165.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b165);

				Book b166 = new Book()
				{
					Title = "The Narrow Road To The Deep North",
					Author = "Richard Flanagan",
					Description = "The hero of the Man Booker Prize-winning novel about love, good and evil is a P.O.W. working on the Thai-Burma Death Railway during World War II.",
					ReleaseDate = new DateTime(2014, 10, 18),
					Price = 34m
				};
				b166.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b166);

				Book b167 = new Book()
				{
					Title = "The Handsome Man's De Luxe Café",
					Author = "Alexander McCall Smith",
					Description = "The 15th book in the No. 1 Ladies’ Detective Agency series.",
					ReleaseDate = new DateTime(2014, 11, 1),
					Price = 25.95m
				};
				b167.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b167);

				Book b168 = new Book()
				{
					Title = "The Burning Room",
					Author = "Michael Connelly",
					Description = "The Los Angeles detective Harry Bosch and his new partner investigate two long-unsolved cases.",
					ReleaseDate = new DateTime(2014, 11, 8),
					Price = 36.99m
				};
				b168.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b168);

				Book b169 = new Book()
				{
					Title = "The Mistletoe Promise",
					Author = "Richard Paul Evans",
					Description = "A divorced woman enters into a contract with a strange man to pretend to be a couple until Christmas.",
					ReleaseDate = new DateTime(2014, 11, 22),
					Price = 23.99m
				};
				b169.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b169);

				Book b170 = new Book()
				{
					Title = "Hope To Die",
					Author = "James Patterson",
					Description = "Detective Alex Cross’s family is kidnapped by a madman who wants to turn Cross into a perfect killer.",
					ReleaseDate = new DateTime(2014, 11, 29),
					Price = 31.95m
				};
				b170.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b170);

				Book b171 = new Book()
				{
					Title = "Trust No One",
					Author = "Jayne Ann Krentz",
					Description = "A woman who is being stalked is aided by an unlikely ally.",
					ReleaseDate = new DateTime(2015, 1, 10),
					Price = 17.95m
				};
				b171.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b171);

				Book b172 = new Book()
				{
					Title = "Trigger Warning",
					Author = "Neil Gaiman",
					Description = "Stories and poems about the power of imagination.",
					ReleaseDate = new DateTime(2015, 2, 7),
					Price = 17.95m
				};
				b172.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Poetry");
				Books.Add(b172);

				Book b173 = new Book()
				{
					Title = "Twelve Days",
					Author = "Alex Berenson",
					Description = "The former C.I.A. operative John Wells discovers a plot to trick the president into invading Iran.",
					ReleaseDate = new DateTime(2015, 2, 14),
					Price = 25m
				};
				b173.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b173);

				Book b174 = new Book()
				{
					Title = "A Spool Of Blue Thread",
					Author = "Anne Tyler",
					Description = "Four generations of a family are drawn to a house in the Baltimore suburbs.",
					ReleaseDate = new DateTime(2015, 2, 14),
					Price = 15.95m
				};
				b174.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b174);

				Book b175 = new Book()
				{
					Title = "Holy Cow",
					Author = "David Duchovny",
					Description = "A light-hearted fable by the actor.",
					ReleaseDate = new DateTime(2015, 2, 14),
					Price = 19.99m
				};
				b175.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
				Books.Add(b175);

				Book b176 = new Book()
				{
					Title = "Prodigal Son",
					Author = "Danielle Steel",
					Description = "Twins, one good and one bad, reunite after 20 years when one of them returns to their hometown. But it is no longer clear who the good and who the bad one is.",
					ReleaseDate = new DateTime(2015, 2, 28),
					Price = 18.95m
				};
				b176.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b176);

				Book b177 = new Book()
				{
					Title = "Last One Home",
					Author = "Debbie Macomber",
					Description = "Three estranged sisters work to resolve their differences",
					ReleaseDate = new DateTime(2015, 3, 14),
					Price = 20m
				};
				b177.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b177);

				Book b178 = new Book()
				{
					Title = "The Lady From Zagreb",
					Author = "Philip Kerr",
					Description = "The former Berlin homicide detective Bernie Gunther is sent to Croatia by Joseph Goebbels to persuade a film star to appear in a movie.",
					ReleaseDate = new DateTime(2015, 4, 11),
					Price = 20.95m
				};
				b178.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b178);

				Book b179 = new Book()
				{
					Title = "The Fateful Lightning",
					Author = "Jeff Shaara",
					Description = "The fourth and final volume in a series of Civil War novels describes the war's last months through multiple perspectives.",
					ReleaseDate = new DateTime(2015, 6, 6),
					Price = 28.95m
				};
				b179.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b179);

				Book b180 = new Book()
				{
					Title = "In The Unlikely Event",
					Author = "Judy Blume",
					Description = "Secrets are revealed and love stories play out against the backdrop of a series of panic-inducing plane crashes in 1950s New Jersey.",
					ReleaseDate = new DateTime(2015, 6, 6),
					Price = 18.95m
				};
				b180.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b180);

				Book b181 = new Book()
				{
					Title = "The Little Paris Bookshop",
					Author = "Nina George",
					Description = "A bookseller with a knack for finding just the right book for making others feel better embarks on a journey in pursuit of his own happiness.",
					ReleaseDate = new DateTime(2015, 7, 4),
					Price = 34m
				};
				b181.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b181);

				Book b182 = new Book()
				{
					Title = "Friction",
					Author = "Sandra Brown",
					Description = "A Texas Ranger fights for custody of his daughter amid complications stemming from his attraction to the judge.",
					ReleaseDate = new DateTime(2015, 8, 22),
					Price = 18.99m
				};
				b182.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b182);

				Book b183 = new Book()
				{
					Title = "The Solomon Curse",
					Author = "Clive Cussler and Russell Blake",
					Description = "The wealthy couple Sam and Remi Fargo investigate a dangerous legend in the Solomon Islands.",
					ReleaseDate = new DateTime(2015, 9, 5),
					Price = 26.95m
				};
				b183.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b183);

				Book b184 = new Book()
				{
					Title = "One Year After",
					Author = "William R Forstchen",
					Description = "A New Regime imposes tyranny in the aftermath of a nuclear attack.",
					ReleaseDate = new DateTime(2015, 9, 19),
					Price = 23.95m
				};
				b184.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b184);

				Book b185 = new Book()
				{
					Title = "The Murder House",
					Author = "James Patterson and David Ellis",
					Description = "When bodies are found at a Hamptons estate where a series of grisly murders once occurred, a local detective and former New York City cop investigates.",
					ReleaseDate = new DateTime(2015, 10, 3),
					Price = 23.95m
				};
				b185.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b185);

				Book b186 = new Book()
				{
					Title = "All The Stars In The Heavens",
					Author = "Adriana Trigiani",
					Description = "A fictional treatment of the life of the actress Loretta Young focuses on her rumored affair with the married Clark Gable and her subsequent pregnancy.",
					ReleaseDate = new DateTime(2015, 10, 17),
					Price = 26.95m
				};
				b186.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b186);

				Book b187 = new Book()
				{
					Title = "The Lake House",
					Author = "Kate Morton",
					Description = "A London detective investigating a missing-persons case becomes curious about an unsolved 1933 kidnapping in Cornwall.",
					ReleaseDate = new DateTime(2015, 10, 24),
					Price = 16.95m
				};
				b187.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b187);

				Book b188 = new Book()
				{
					Title = "The Japanese Lover",
					Author = "Isabel Allende",
					Description = "A young refugee from the Nazis and the son of her family’s Japanese gardener must hide their love, although it lasts a lifetime.",
					ReleaseDate = new DateTime(2015, 11, 7),
					Price = 33.99m
				};
				b188.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b188);

				Book b189 = new Book()
				{
					Title = "The Promise",
					Author = "Robert Crais",
					Description = "The Los Angeles P.I. Elvis Cole joins forces with the K-9 officer Scott James of the L.A.P.D. and his German shepherd, Maggie, as well as his partner, Joe Pike, to foil a criminal mastermind.",
					ReleaseDate = new DateTime(2015, 11, 14),
					Price = 27.95m
				};
				b189.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b189);

				Book b190 = new Book()
				{
					Title = "The Pharaoh's Secret",
					Author = "Clive Cussler and Graham Brown",
					Description = "Kurt Austin and Joe Zavala must save the NUMA crew from a mysterious toxin deployed by a villain who wants to build a new Egyptian empire.",
					ReleaseDate = new DateTime(2015, 11, 21),
					Price = 31.95m
				};
				b190.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b190);

				Book b191 = new Book()
				{
					Title = "The Guilty",
					Author = "David Baldacci",
					Description = "The government hit man Will Robie investigates murder charges against his estranged father in their Mississippi hometown.",
					ReleaseDate = new DateTime(2015, 11, 21),
					Price = 19.95m
				};
				b191.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b191);

				Book b192 = new Book()
				{
					Title = "The Mistletoe Inn",
					Author = "Richard Paul Evans",
					Description = "An aspiring romance writer with a broken heart meets a complicated man at a Christmas writers’ retreat.",
					ReleaseDate = new DateTime(2015, 11, 21),
					Price = 36.95m
				};
				b192.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b192);

				Book b193 = new Book()
				{
					Title = "Find Her",
					Author = "Lisa Gardner",
					Description = "The Boston detective D.D. Warren hunts for a missing woman who was kidnapped and abused as a college student and may have become a vigilante.",
					ReleaseDate = new DateTime(2016, 2, 13),
					Price = 28.95m
				};
				b193.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b193);

				Book b194 = new Book()
				{
					Title = "Wedding Cake Murder",
					Author = "Joanne Fluke",
					Description = "The Lake Eden, Minn., baker Hannah Swensen is about to get married, but first she must solve the murder of a visiting celebrity chef. Recipes included.",
					ReleaseDate = new DateTime(2016, 2, 27),
					Price = 23.95m
				};
				b194.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b194);

				Book b195 = new Book()
				{
					Title = "The Gangster",
					Author = "Clive Cussler and Justin Scott",
					Description = "n the ninth book in this series, set in 1906, the New York detective Isaac Bell contends with a crime boss passing as a respectable businessman and a tycoon’s plot against President Theodore Roosevelt.",
					ReleaseDate = new DateTime(2016, 3, 5),
					Price = 30.95m
				};
				b195.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b195);

				Book b196 = new Book()
				{
					Title = "Fool Me Once",
					Author = "Harlan Coben",
					Description = "A retired Army helicopter pilot faces combat-related nightmares and mysteries concerning the deaths of her husband and sister.",
					ReleaseDate = new DateTime(2016, 3, 26),
					Price = 24.95m
				};
				b196.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b196);

				Book b197 = new Book()
				{
					Title = "Robert B. Parker's Slow Burn",
					Author = "Ace Atkins",
					Description = "Spenser is back, leaving a trail of antagonism as he investigates a series of suspicious Boston fires.",
					ReleaseDate = new DateTime(2016, 5, 7),
					Price = 22.99m
				};
				b197.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b197);

				Book b198 = new Book()
				{
					Title = "Zero K",
					Author = "Don DeLillo",
					Description = "A billionaire and his son meet at a remote desert compound dedicated to preserving bodies until they can be returned to life in the future.",
					ReleaseDate = new DateTime(2016, 5, 7),
					Price = 20m
				};
				b198.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b198);

				Book b199 = new Book()
				{
					Title = "The Second Life Of Nick Mason",
					Author = "Steve Hamilton",
					Description = "A deal with a fellow inmate, a crime boss, springs Nick Mason from prison, but he must become an assassin.",
					ReleaseDate = new DateTime(2016, 5, 21),
					Price = 19.99m
				};
				b199.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b199);

				Book b200 = new Book()
				{
					Title = "The Weekenders",
					Author = "Mary Kay Andrews",
					Description = "On the North Carolina island of Belle Isle, a woman investigates her husband’s shady financial affairs after his mysterious death.",
					ReleaseDate = new DateTime(2016, 5, 21),
					Price = 20.95m
				};
				b200.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b200);

				Book b201 = new Book()
				{
					Title = "The Emperor's Revenge",
					Author = "Clive Cussler and Boyd Morrison",
					Description = "Juan Cabrillo teams up with a former C.I.A. colleague to thwart a plan involving the death of millions and international economic meltdown.",
					ReleaseDate = new DateTime(2016, 6, 4),
					Price = 27.99m
				};
				b201.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b201);

				Book b202 = new Book()
				{
					Title = "Homegoing",
					Author = "Yaa Gyasi",
					Description = "This Ghanaian-American writer’s first novel traces the lives in West Africa and America of seven generations of the descendants of two half sisters.",
					ReleaseDate = new DateTime(2016, 6, 11),
					Price = 26.95m
				};
				b202.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b202);

				Book b203 = new Book()
				{
					Title = "Here's To Us",
					Author = "Elin Hilderbrand",
					Description = "Sparks fly as a celebrity chef’s ex-wives pile into a small cabin in Nantucket to join his widow for the reading of his will.",
					ReleaseDate = new DateTime(2016, 6, 18),
					Price = 26.95m
				};
				b203.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b203);

				Book b204 = new Book()
				{
					Title = "The Pursuit",
					Author = "Janet Evanovich and Lee Goldberg",
					Description = "The F.B.I. agent Kate O’Hare and her con man partner, Nick Fox, face off against a dangerous ex-Serbian military officer.",
					ReleaseDate = new DateTime(2016, 6, 25),
					Price = 25.99m
				};
				b204.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b204);

				Book b205 = new Book()
				{
					Title = "Among The Wicked",
					Author = "Linda Castillo",
					Description = "Chief of Police Kate Burkholder goes undercover as a widow in a reclusive Amish community to investigate a girl's death.",
					ReleaseDate = new DateTime(2016, 7, 16),
					Price = 24m
				};
				b205.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b205);

				Book b206 = new Book()
				{
					Title = "The Woman In Cabin 10",
					Author = "Ruth Ware",
					Description = "A travel writer on a cruise is certain she has heard a body thrown overboard, but no one believes her.",
					ReleaseDate = new DateTime(2016, 7, 23),
					Price = 32m
				};
				b206.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
				Books.Add(b206);

				Book b207 = new Book()
				{
					Title = "Truly Madly Guilty",
					Author = "Liane Moriarty",
					Description = "Tense turning points for three couples at a backyard barbecue gone wrong.",
					ReleaseDate = new DateTime(2016, 7, 30),
					Price = 14.99m
				};
				b207.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b207);

				Book b208 = new Book()
				{
					Title = "The Underground Railroad",
					Author = "Colson Whitehead",
					Description = "A slave girl heads toward freedom on the network, envisioned as actual tracks and tunnels.",
					ReleaseDate = new DateTime(2016, 8, 6),
					Price = 32m
				};
				b208.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b208);

				Book b209 = new Book()
				{
					Title = "Dragonmark",
					Author = "Sherrilyn Kenyon",
					Description = "The first book of a new trilogy featuring Illarion, a dragon made into a human  against his will. A Dark-Hunter novel.",
					ReleaseDate = new DateTime(2016, 8, 6),
					Price = 29.95m
				};
				b209.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b209);

				Book b210 = new Book()
				{
					Title = "Another Brooklyn",
					Author = "Jacqueline Woodson",
					Description = "An adult novel by an award-winning children's book author centers on memories of growing up and the close friendship of four girls.",
					ReleaseDate = new DateTime(2016, 8, 13),
					Price = 36m
				};
				b210.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b210);

				Book b211 = new Book()
				{
					Title = "Sting",
					Author = "Sandra Brown",
					Description = "A hired killer and a woman he kidnapped join forces to elude the F.B.I. agents and others who are searching for her corrupt brother.",
					ReleaseDate = new DateTime(2016, 8, 20),
					Price = 27m
				};
				b211.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b211);

				Book b212 = new Book()
				{
					Title = "The Kept Woman",
					Author = "Karin Slaughter",
					Description = "Will Trent of the Georgia Bureau of Investigation and his lover, the medical examiner Sara Linton, pursue a case involving a dirty Atlanta cop.",
					ReleaseDate = new DateTime(2016, 9, 24),
					Price = 16.95m
				};
				b212.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b212);

				Book b213 = new Book()
				{
					Title = "Twelve Days Of Christmas",
					Author = "Debbie Macomber",
					Description = "A woman starts a blog about her attempt to reach out to a grumpy neighbor at Christmastime, and finds herself falling for him.",
					ReleaseDate = new DateTime(2016, 10, 8),
					Price = 25.99m
				};
				b213.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b213);

				Book b214 = new Book()
				{
					Title = "Winter Storms",
					Author = "Elin Hilderbrand",
					Description = "In the final book of the Winter Street trilogy, a huge snowstorm bearing down on Nantucket threatens the Quinn family’s Christmas, after a year of significant events.",
					ReleaseDate = new DateTime(2016, 10, 8),
					Price = 29m
				};
				b214.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b214);

				Book b215 = new Book()
				{
					Title = "Vince Flynn: Order To Kill",
					Author = "Kyle Mills",
					Description = "Flynn’s character, the C.I.A. operative Mitch Rapp, uncovers a dangerous Russian plot. Flynn died in 2013.",
					ReleaseDate = new DateTime(2016, 10, 15),
					Price = 16.95m
				};
				b215.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b215);

				Book b216 = new Book()
				{
					Title = "Crimson Death",
					Author = "Laurell K Hamilton",
					Description = "The vampire hunter Anita Blake, her friend Edward and her servant Damian travel to Ireland to battle an unusual vampire infestation.",
					ReleaseDate = new DateTime(2016, 10, 15),
					Price = 16.99m
				};
				b216.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b216);

				Book b217 = new Book()
				{
					Title = "Escape Clause",
					Author = "John Sandford",
					Description = "Virgil Flowers of the Minnesota Bureau of Criminal Apprehension must deal with the theft of tigers from the local zoo.",
					ReleaseDate = new DateTime(2016, 10, 22),
					Price = 35.95m
				};
				b217.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b217);

				Book b218 = new Book()
				{
					Title = "The Whistler",
					Author = "John Grisham",
					Description = "A whistleblower alerts a Florida investigator to judicial corruption involving the Mob and Indian casinos.",
					ReleaseDate = new DateTime(2016, 10, 29),
					Price = 26.95m
				};
				b218.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b218);

				Book b219 = new Book()
				{
					Title = "The Whole Town's Talking",
					Author = "Fannie Flagg",
					Description = "A century of life in small-town Elmwood Springs, Mo.",
					ReleaseDate = new DateTime(2016, 12, 3),
					Price = 31.99m
				};
				b219.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b219);

				Book b220 = new Book()
				{
					Title = "Rogue One: A Star Wars Story",
					Author = "Alexander Freed",
					Description = "A novelization of the new movie, including additional scenes.",
					ReleaseDate = new DateTime(2016, 12, 24),
					Price = 33.95m
				};
				b220.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b220);

				Book b221 = new Book()
				{
					Title = "The Mistress",
					Author = "Danielle Steel",
					Description = "The beautiful mistress of a Russian oligarch falls in love with an artist and yearns for freedom.",
					ReleaseDate = new DateTime(2017, 1, 7),
					Price = 36.95m
				};
				b221.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b221);

				Book b222 = new Book()
				{
					Title = "Ring Of Fire",
					Author = "Brad Taylor",
					Description = "Pike Logan, a member of a secret counterterrorist unit called the Taskforce, investigates a Saudi-backed Moroccan terrorist cell.",
					ReleaseDate = new DateTime(2017, 1, 14),
					Price = 22m
				};
				b222.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b222);

				Book b223 = new Book()
				{
					Title = "Death's Mistress",
					Author = "Terry Goodkind",
					Description = "The first book of a new series, the Nicci Chronicles, centers on a character from the Sword of Truth fantasy series.",
					ReleaseDate = new DateTime(2017, 1, 28),
					Price = 20m
				};
				b223.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b223);

				Book b224 = new Book()
				{
					Title = "4 3 2 1",
					Author = "Paul Auster",
					Description = "Four versions of the formative years of a Jewish boy born in Newark in 1947.",
					ReleaseDate = new DateTime(2017, 2, 4),
					Price = 20.95m
				};
				b224.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b224);

				Book b225 = new Book()
				{
					Title = "Gunmetal Gray",
					Author = "Mark Greaney",
					Description = "Court Gentry, now working for the C.I.A., pursues a Chinese hacker who is on the run.",
					ReleaseDate = new DateTime(2017, 2, 18),
					Price = 21.95m
				};
				b225.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b225);

				Book b226 = new Book()
				{
					Title = "Banana Cream Pie Murder",
					Author = "Joanne Fluke",
					Description = "Hannah Swensen, the bakery owner and amateur sleuth of Lake Eden, Minn., returns from her honeymoon to confront an actress’s mysterious death.",
					ReleaseDate = new DateTime(2017, 3, 4),
					Price = 36.95m
				};
				b226.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b226);

				Book b227 = new Book()
				{
					Title = "Silence Fallen",
					Author = "Patricia Briggs",
					Description = "The shape-shifter Mercy Thompson finds herself in the clutches of the world’s most powerful vampire.",
					ReleaseDate = new DateTime(2017, 3, 11),
					Price = 36m
				};
				b227.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
				Books.Add(b227);

				Book b228 = new Book()
				{
					Title = "Without Warning",
					Author = "Joel C Rosenberg",
					Description = "A journalist pursues the head of ISIS after an attack on the Capitol when the administration fails to take action.",
					ReleaseDate = new DateTime(2017, 3, 18),
					Price = 27.95m
				};
				b228.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b228);

				Book b229 = new Book()
				{
					Title = "Song Of The Lion",
					Author = "Anne Hillerman",
					Description = "The third Southwestern mystery featuring the Navajo police officer Bernadette Manuelito and her husband, Jim Chee.",
					ReleaseDate = new DateTime(2017, 4, 15),
					Price = 31.99m
				};
				b229.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b229);

				Book b230 = new Book()
				{
					Title = "The Burial Hour",
					Author = "Jeffery Deaver",
					Description = "Lincoln Rhyme travels to Italy to investigate a case.",
					ReleaseDate = new DateTime(2017, 4, 15),
					Price = 16m
				};
				b230.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b230);

				Book b231 = new Book()
				{
					Title = "The Identicals",
					Author = "Elin Hilderbrand",
					Description = "Complications in the lives of identical twins who were raised by their divorced parents, one on Nantucket, one on Martha’s Vineyard.",
					ReleaseDate = new DateTime(2017, 6, 17),
					Price = 33.95m
				};
				b231.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b231);

				Book b232 = new Book()
				{
					Title = "House Of Spies",
					Author = "Daniel Silva",
					Description = "Gabriel Allon, the Israeli art restorer and spy, now the head of Israel’s secret intelligence service, pursues an ISIS mastermind.",
					ReleaseDate = new DateTime(2017, 7, 15),
					Price = 33.95m
				};
				b232.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b232);

				Book b233 = new Book()
				{
					Title = "Two Nights",
					Author = "Kathy Reichs",
					Description = "Sunday Night, the heroine of a new series from the creator of Temperance Brennan, searches for a girl who may have been kidnapped by a cult.",
					ReleaseDate = new DateTime(2017, 7, 15),
					Price = 17.95m
				};
				b233.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b233);

				Book b234 = new Book()
				{
					Title = "Meddling Kids",
					Author = "Edgar Cantero",
					Description = "Four old friends return to the site of their teenage adventures.",
					ReleaseDate = new DateTime(2017, 7, 22),
					Price = 30.95m
				};
				b234.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b234);

				Book b235 = new Book()
				{
					Title = "Watch Me Disappear",
					Author = "Janelle Brown",
					Description = "When a Berkeley woman vanishes after a hiking trip, her husband and daughter discover disturbing secrets.",
					ReleaseDate = new DateTime(2017, 7, 22),
					Price = 32.95m
				};
				b235.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b235);

				Book b236 = new Book()
				{
					Title = "I Know A Secret",
					Author = "Tess Gerritsen",
					Description = "Rizzoli and Isles investigate two separate homicides and uncover other dangerous mysteries.",
					ReleaseDate = new DateTime(2017, 8, 19),
					Price = 32.95m
				};
				b236.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b236);

				Book b237 = new Book()
				{
					Title = "Sulfur Springs",
					Author = "William Kent Krueger",
					Description = "A newly married couple search for the wife's missing son, which leads them to a border town in the middle of a drug war.",
					ReleaseDate = new DateTime(2017, 8, 26),
					Price = 32.95m
				};
				b237.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b237);

				Book b238 = new Book()
				{
					Title = "Enemy Of The State",
					Author = "Kyle Mills",
					Description = "Vince Flynn's character Mitch Rapp leaves the C.I.A. to go on a manhunt when the nephew of a Saudi King finances a terrorist group.",
					ReleaseDate = new DateTime(2017, 9, 9),
					Price = 20.95m
				};
				b238.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b238);

				Book b239 = new Book()
				{
					Title = "Little Fires Everywhere",
					Author = "Celeste Ng",
					Description = "An artist with a mysterious past and a disregard for the status quo upends a quiet town outside Cleveland.",
					ReleaseDate = new DateTime(2017, 9, 16),
					Price = 16m
				};
				b239.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b239);

				Book b240 = new Book()
				{
					Title = "The House Of Unexpected Sisters",
					Author = "Alexander McCall Smith",
					Description = "During an investigation, Precious Ramotswe encounters a man from her past and a nurse who has her last name.",
					ReleaseDate = new DateTime(2017, 11, 11),
					Price = 29.95m
				};
				b240.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b240);

				Book b241 = new Book()
				{
					Title = "Artemis",
					Author = "Andy Weir",
					Description = "A small-time smuggler living in a lunar colony schemes to pay off an old debt by pulling off a challenging heist.",
					ReleaseDate = new DateTime(2017, 11, 18),
					Price = 31m
				};
				b241.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
				Books.Add(b241);

				Book b242 = new Book()
				{
					Title = "The Grave's A Fine And Private Place",
					Author = "Alan Bradley",
					Description = "Flavia de Luce, a young British sleuth, gets involved in solving a murder after experiencing a family tragedy.",
					ReleaseDate = new DateTime(2018, 2, 3),
					Price = 26.95m
				};
				b242.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b242);

				Book b243 = new Book()
				{
					Title = "An American Marriage",
					Author = "Tayari Jones",
					Description = "A newlywed couple's relationship is tested when the husband is sentenced to 12 years in prison.",
					ReleaseDate = new DateTime(2018, 2, 10),
					Price = 22.95m
				};
				b243.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b243);

				Book b244 = new Book()
				{
					Title = "To Die But Once",
					Author = "Jacqueline Winspear",
					Description = "In 1940, months after Britain declared war on Germany, Maisie Dobbs investigates the disappearance of an apprentice working on a government contract.",
					ReleaseDate = new DateTime(2018, 3, 31),
					Price = 24.95m
				};
				b244.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
				Books.Add(b244);

				Book b245 = new Book()
				{
					Title = "Macbeth",
					Author = "Jo Nesbo",
					Description = "In this adaptation of Shakespeare's tragedy, police in a 1970s industrial town take on a pair of drug lords.",
					ReleaseDate = new DateTime(2018, 4, 14),
					Price = 28.95m
				};
				b245.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Shakespeare");
				Books.Add(b245);

				Book b246 = new Book()
				{
					Title = "The High Tide Club",
					Author = "Mary Kay Andrews",
					Description = "An eccentric millionaire enlists the attorney Brooke Trappnell to fix old wrongs, which sets up a potential scandal and murder.",
					ReleaseDate = new DateTime(2018, 5, 12),
					Price = 23.95m
				};
				b246.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b246);

				Book b247 = new Book()
				{
					Title = "Warlight",
					Author = "Michael Ondaatje",
					Description = "In Britain after World War II, a pair of teenage siblings are taken under the tutelage of a mysterious man and his cronies who served during the war.",
					ReleaseDate = new DateTime(2018, 5, 12),
					Price = 26m
				};
				b247.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
				Books.Add(b247);

				Book b248 = new Book()
				{
					Title = "The Cast",
					Author = "Danielle Steel",
					Description = "A magazine columnist meets an array of Hollywood professionals when a producer turns a story about her grandmother into a TV series.",
					ReleaseDate = new DateTime(2018, 5, 19),
					Price = 21.95m
				};
				b248.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
				Books.Add(b248);

				Book b249 = new Book()
				{
					Title = "Beach House Reunion",
					Author = "Mary Alice Monroe",
					Description = "Three generations of a family gather one summer in South Carolina.",
					ReleaseDate = new DateTime(2018, 5, 26),
					Price = 32.95m
				};
				b249.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
				Books.Add(b249);

				Book b250 = new Book()
				{
					Title = "Turbulence",
					Author = "Stuart Woods",
					Description = "The 46th book in the Stone Barrington series.",
					ReleaseDate = new DateTime(2018, 6, 9),
					Price = 15.95m
				};
				b250.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
				Books.Add(b250);

				try
				{
					foreach (Book bookToAdd in Books)
					{
						strBookTitle = bookToAdd.Title;
						Book dbBook = db.Books.FirstOrDefault(b => b.Title == bookToAdd.Title);
						if (dbBook == null) //this title doesn't exist
						{
							db.Books.Add(bookToAdd);
							db.SaveChanges();
							intBooksAdded += 1;
						}
						else //book exists - update values
						{
							dbBook.Title = bookToAdd.Title;
							dbBook.Author = bookToAdd.Author;
							dbBook.ReleaseDate = bookToAdd.ReleaseDate;
							dbBook.Description = bookToAdd.Description;
							dbBook.Price = bookToAdd.Price;
							dbBook.Genre = bookToAdd.Genre;
							db.Update(dbBook);
							db.SaveChanges();
							intBooksAdded += 1;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = "  Repositories added:" + intBooksAdded + "; Error on " + strBookTitle;
					throw new InvalidOperationException(ex.Message + msg);
				}
			}
			catch (Exception e)
			{
				throw new InvalidOperationException(e.Message);
			}
		}
	}
}
