using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airport.DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class MigrationSeeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AircraftTypeId", "Condition", "FlightHours", "Manufacturer", "Model", "Year" },
                values: new object[,]
                {
                    { 1, 3, "A", 559, "Safran", "LEAP-1A", 2021 },
                    { 2, 4, "A", 275, "Safran", "LEAP-1B", 2012 },
                    { 3, 1, "B", 0, "Safran", "LEAP-1C", 2004 },
                    { 4, 1, "C", 703, "Safran", "CFM56", 2020 },
                    { 5, 4, "B", 303, "Safran", "SaM146", 2016 },
                    { 6, 5, "B", 636, "Safran", "TP400", 2006 },
                    { 7, 2, "C", 695, "Safran", "M88", 2001 },
                    { 8, 2, "C", 527, "Safran", "SaM14612", 2015 },
                    { 9, 2, "B", 835, "Safran", "LEAP-1D", 2013 },
                    { 10, 1, "C", 639, "Safran", "LEAP-1H", 2002 },
                    { 11, 8, "A", 885, "Safran", "LEAP-1H", 2019 },
                    { 12, 9, "C", 357, "Safran", "LEAP-1J", 2008 },
                    { 13, 10, "B", 849, "Safran", "TP500", 2007 },
                    { 14, 11, "B", 98, "Safran", "TP600", 2020 },
                    { 15, 12, "B", 334, "Northrop Grumman", "EA-6 Prowler", 2021 },
                    { 16, 13, "C", 617, "Northrop Grumman", "E-2 Hawkeye", 2007 },
                    { 17, 14, "A", 720, "Northrop Grumman", "C-2 Greyhound", 2019 },
                    { 18, 15, "A", 0, "Northrop Grumman", "Model 151 (ARES)", 2004 },
                    { 19, 1, "B", 64, "Northrop Grumman", "Douglas YF-23 ", 2015 },
                    { 20, 2, "C", 480, "Northrop Grumman", "E-8 Joint STARS", 2015 },
                    { 21, 3, "A", 620, "Northrop Grumman", "TRW RQ-5 Hunter", 2010 },
                    { 22, 4, "B", 796, "Northrop Grumman", "B-2 Spirit", 2002 },
                    { 23, 5, "B", 906, "Northrop Grumman", "X-47A Pegasus", 2020 },
                    { 24, 6, "C", 149039, "Northrop Grumman", "Bat", 2008 },
                    { 25, 7, "A", 414, "Northrop Grumman", "KC-45 (KC-30)", 2002 },
                    { 26, 8, "C", 342, "Northrop Grumman", "Sandstorm", 2002 },
                    { 27, 9, "C", 894, "Northrop Grumman", "DARPA KQ-X", 2010 },
                    { 28, 10, "C", 380, "GE Aviation", "GE90", 2013 },
                    { 29, 11, "A", 148, "GE Aviation", "GE9X", 2011 },
                    { 30, 12, "A", 65, "GE Aviation", "GEnx", 2007 },
                    { 31, 13, "B", 395, "GE Aviation", "GP7200c", 2007 },
                    { 32, 14, "C", 936, "GE Aviation", "CF6", 2000 },
                    { 33, 15, "A", 128, "GE Aviation", "CFM56", 2008 },
                    { 34, 6, "C", 847, "GE Aviation", "LEAP", 2004 },
                    { 35, 7, "A", 18, "GE Aviation", "CF34", 2011 },
                    { 36, 8, "B", 96, "GE Aviation", "CT7", 2005 },
                    { 37, 9, "B", 4, "GE Aviation", "CT8", 2020 },
                    { 38, 10, "C", 112, "GE Aviation", "CT9", 2020 },
                    { 39, 11, "A", 275, "GE Aviation", "CT10", 2002 },
                    { 40, 14, "B", 582, "GE Aviation", "CF67", 2007 },
                    { 41, 11, "A", 508, "GE Aviation", "CF8", 2001 },
                    { 42, 15, "B", 574, "GE Aviation", "CF9", 2004 },
                    { 43, 12, "A", 499, "GE Aviation", "CF10", 2003 },
                    { 44, 11, "C", 623, "Boeing", "787", 2004 },
                    { 45, 13, "C", 0, "Boeing", "787", 2007 },
                    { 46, 11, "B", 386, "Boeing", "787", 2019 },
                    { 47, 12, "A", 849, "Boeing", "787", 2009 },
                    { 48, 13, "B", 0, "Boeing", "787", 2021 },
                    { 49, 12, "B", 382, "Boeing", "787", 2010 },
                    { 50, 13, "A", 440, "Boeing", "787", 2011 },
                    { 51, 7, "B", 414, "Boeing", "787", 2013 },
                    { 52, 8, "B", 591, "Boeing", "787", 2012 },
                    { 53, 9, "C", 0, "Boeing", "787", 2007 },
                    { 54, 10, "C", 118, "Boeing", "787", 2013 },
                    { 55, 7, "A", 246, "Boeing", "747", 2012 },
                    { 56, 8, "B", 147, "Boeing", "747", 2010 },
                    { 57, 9, "A", 189, "Boeing", "747", 2019 },
                    { 58, 10, "B", 349, "Boeing", "BBJ", 2001 },
                    { 59, 1, "C", 925, "Boeing", "BBJ", 2013 },
                    { 60, 12, "C", 860, "Boeing", "BBJ", 2007 },
                    { 61, 13, "B", 131, "Boeing", "737", 2005 },
                    { 62, 14, "C", 870, "Boeing", "737", 2002 },
                    { 63, 15, "C", 599, "Boeing", "737", 2020 },
                    { 64, 2, "A", 824, "Boeing", "737", 2010 },
                    { 65, 1, "A", 775, "Rolls-Royce Holdings", "Trent XWB", 2005 },
                    { 66, 4, "B", 958, "Rolls-Royce Holdings", "Trent 900", 2005 },
                    { 67, 4, "C", 100, "Rolls-Royce Holdings", "EJ200", 2003 },
                    { 68, 2, "C", 256, "Rolls-Royce Holdings", "Eurofighter Typhoon", 2001 },
                    { 69, 1, "C", 776, "Rolls-Royce Holdings", "Trent 700", 2006 },
                    { 70, 5, "C", 225, "Rolls-Royce Holdings", "Trent 500", 2010 },
                    { 71, 6, "B", 571, "Lockheed Martin", "P-38 Lightning", 2011 },
                    { 72, 7, "B", 557, "Lockheed Martin", "P-80 Shooting Star", 2002 },
                    { 73, 8, "A", 839, "Lockheed Martin", "F-94 Starfire", 2018 },
                    { 74, 9, "C", 805, "Lockheed Martin", "F-104 Starfighter", 2008 },
                    { 75, 10, "C", 459, "Lockheed Martin", "F-16 Fighting Falcon", 2016 },
                    { 76, 11, "A", 122, "Lockheed Martin", "F-117 Nighthawk", 2003 },
                    { 77, 12, "A", 633, "Lockheed Martin", "F-22 Raptor", 2013 },
                    { 78, 13, "A", 603, "Lockheed Martin", "A-4AR Fightinghawk", 2004 },
                    { 79, 14, "A", 623, "Lockheed Martin", "F-35 Lightning II", 2000 },
                    { 80, 15, "A", 714, "Lockheed Martin", "A-4AR Fightinghawk", 2015 },
                    { 81, 5, "A", 271, "Lockheed Martin", "F-22 Raptor", 2004 },
                    { 82, 6, "C", 28, "Lockheed Martin", "F-117 Nighthawk", 2006 },
                    { 83, 7, "A", 570, "Lockheed Martin", "F-16 Fighting Falcon", 2003 },
                    { 84, 8, "C", 409, "Airbus", "A220", 2003 },
                    { 85, 9, "B", 780, "Airbus", "A300", 2000 },
                    { 86, 15, "C", 243, "Airbus", "A310", 2012 },
                    { 87, 10, "B", 359, "Airbus", "A318", 2021 },
                    { 88, 11, "B", 501, "Airbus", "A319", 2015 },
                    { 89, 12, "C", 15, "Airbus", "A320", 2001 },
                    { 90, 3, "A", 62, "Airbus", "A321", 2017 },
                    { 91, 4, "B", 491, "Airbus", "A330", 2011 },
                    { 92, 5, "A", 393, "Airbus", "A340", 2009 },
                    { 93, 6, "B", 785, "Airbus", "A350", 2010 },
                    { 94, 7, "C", 223, "Airbus", "A380", 2003 },
                    { 95, 8, "A", 101, "Bombardier Aerospace", "CRJ700", 2018 },
                    { 96, 9, "B", 280, "Bombardier Aerospace", "CRJ900", 2008 },
                    { 97, 10, "A", 341, "Bombardier Aerospace", "Global Express", 2012 },
                    { 98, 11, "B", 210, "Bombardier Aerospace", "Learjet 75", 2015 },
                    { 99, 12, "C", 370, "Bombardier Aerospace", "Challenger 350", 2006 },
                    { 100, 13, "A", 424, "Bombardier Aerospace", "Dash 8 Q400", 2007 }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Algeria", "Touat-Cheikh Sidi Mohamed Belkebir Airport" },
                    { 2, "Benin", "Cadjehoun Airport" },
                    { 3, "Botswana", "Sir Seretse Khama International Airport" },
                    { 4, "Burkina Faso", "Thomas Sankara International Airport Ouagadougou" },
                    { 5, "Burundi", "Bujumbura International Airport" },
                    { 6, "Cameroon", "Douala International Airport" },
                    { 7, "Cape Verde", "Aristides Pereira International Airport" },
                    { 8, "Central African Republic", "Bangui M'Poko International Airport" },
                    { 9, "Chad", "N'Djamena International Airport" },
                    { 10, "Comoros", "Prince Said Ibrahim International Airport" },
                    { 11, "Democratic Republic of the Congo", "Kisangani Bangoka International Airport" },
                    { 12, "Republic of the Congo", "Agostinho-Neto International Airport" },
                    { 13, "Egypt", "Sharm El Sheikh International Airport" },
                    { 14, "Equatorial Guinea", "Malabo International Airport" },
                    { 15, "Eritrea", "Asmara International Airport" },
                    { 16, "Eswatini", "King Mswati III International Airport" },
                    { 17, "Ethiopia", "Addis Ababa Bole International Airport" },
                    { 18, "Gabon", "M'Vengue El Hadj Omar Bongo Ondimba International Airport" },
                    { 19, "The Gambia", "Banjul International Airport" },
                    { 20, "Ghana", "Kotoka International Airport" },
                    { 21, "Guinea", "Conakry International Airport" },
                    { 22, "Guinea-Bissau", "Osvaldo Vieira International Airport" },
                    { 23, "Kenya", "Jomo Kenyatta International Airport" },
                    { 24, "Liberia", "Roberts International Airport" },
                    { 25, "Libya", "Tripoli International Airport" },
                    { 26, "Madagascar", "Ivato International Airport" },
                    { 27, "Malawi", "Lilongwe International Airport" },
                    { 28, "Mali", "Modibo Keita International Airport" },
                    { 29, "Mauritania", "Nouakchottoumtounsy International Airport" },
                    { 30, "Mauritius", "Sir Seewoosagur Ramgoolam International Airport" },
                    { 31, "Mayotte", "Dzaoudzi Pamandzi International Airport" },
                    { 32, "Morocco", "Tangier Ibn Battouta Airport" },
                    { 33, "Mozambique", "Maputo International Airport" },
                    { 34, "Namibia", "Hosea Kutako International Airport" },
                    { 35, "Nigeria", "Mallam Aminu Kano International Airport" },
                    { 36, "Saint Helena, Ascension and Tristan da Cunha", "Saint Helena Airport" },
                    { 37, "Somalia", "Aden Adde International Airport" },
                    { 38, "South Africa", "Kruger Mpumalanga International Airport" },
                    { 39, "Tunisia", "Monastir Habib Bourguiba International Airport" },
                    { 40, "Dominican Republic", "Punta Cana International Airport" },
                    { 41, "Turks and Caicos Islands", "Providenciales Airport" },
                    { 42, "Canada", "Winnipeg James Armstrong Richardson International Airport" },
                    { 43, "Mexico", "Miguel Hidalgo y Costilla Guadalajara International Airport" },
                    { 44, "United States", "Logan International Airport" },
                    { 45, "Brazil", "Presidente Castro Pinto International Airport" },
                    { 46, "Kazakhstan", "Nursultan Nazarbayev International Airport" },
                    { 47, "Japan", "Chubu Centrair International Airport" },
                    { 48, "", "55759 Valley Edge Pass" },
                    { 49, "China", "Guiyang Longdongbao International Airport" },
                    { 50, "India", "Netaji Subhas Chandra Bose International Airport" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
