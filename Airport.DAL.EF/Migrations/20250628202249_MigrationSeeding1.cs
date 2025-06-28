using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airport.DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class MigrationSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, "KalindiKeningham@gmail.com", "Kalindi Keningham" },
                    { 2, "LoisLeidle@gmail.com", "Lois Leidle" },
                    { 3, "CasiFarens@gmail.com", "Casi Farens" },
                    { 4, "JannaKellert@gmail.com", "Janna Kellert" },
                    { 5, "ConnyBarnwille@gmail.com", "Conny Barnwille" },
                    { 6, "PierretteDunmuir@gmail.com", "Pierrette Dunmuir" },
                    { 7, "JasenYeldham@gmail.com", "Jasen Yeldham" },
                    { 8, "JosiHammelberg@gmail.com", "Josi Hammelberg" },
                    { 9, "UrsulinaPartner@gmail.com", "Ursulina Partner" },
                    { 10, "MerisShale@gmail.com", "Meris Shale" },
                    { 11, "CollineDann@gmail.com", "Colline Dannme" },
                    { 12, "JoyannGarrettson@gmail.com", "Joyann Garrettson" },
                    { 13, "ShaneArr@gmail.com", "Shane Arorbe" },
                    { 14, "OwenStrivens@gmail.com", "Owen Strivens" },
                    { 15, "MoynaBosnell@gmail.com", "Moyna Bosnell" },
                    { 16, "Henrik@gmail.com", "Henrik Sivyer" },
                    { 17, "Cullan@gmail.com", "Cullan Dogerty" },
                    { 18, "Aitken@gmail.com", "Jens Aitken" },
                    { 19, "Kryszkiecicz@gmail.com", "Lorilee Kryszkiecicz" },
                    { 20, "Myrta@gmail.com", "Myrta Soggete" },
                    { 21, "Craig@gmail.com", "Craig Backeren" },
                    { 22, "Plackstone@gmail.com", "Jacquelynn Plackstone" },
                    { 23, "Gerwood@gmail.com", "Therese Gerwood" },
                    { 24, "Montacute@gmail.com", "Jefferson Montacute" },
                    { 25, "Elgar@gmail.com", "Jameson Elgarerson" },
                    { 26, "Shalders@gmail.com", "Gilberte Shalders" },
                    { 27, "Simony@gmail.com", "Siegfried Simony" },
                    { 28, "Deem@gmail.com", "Kimball Deemond" },
                    { 29, "Ruddom@gmail.com", "Sascha Ruddom" },
                    { 30, "Janelle Southern@gmail.com", "Janelle Southern" },
                    { 31, "ChaunceTaffe@gmail.com", "Chaunce Taffe" },
                    { 32, "DanteSagerson@gmail.com", "Dante Sagerson" },
                    { 33, "CareyFlannery@gmail.com", "Carey Flannery" },
                    { 34, "LizzieIscowitz@gmail.com", "Lizzie Iscowitz" },
                    { 35, "ZekeRowston@gmail.com", "Zeke Rowston" },
                    { 36, "AdelleKurten@gmail.com", "Adelle Kurten" },
                    { 37, "RollandTrevna@gmail.com", "Rolland Trevna" },
                    { 38, "GwynneBleakley@gmail.com", "Gwynne Bleakley" },
                    { 39, "DarbyRothert@gmail.com", "Darby Rothert" },
                    { 40, "MeridelStraker@gmail.com", "Meridel Straker" },
                    { 41, "RaynorDobbison@gmail.com", "Raynor Dobbison" },
                    { 42, "BurnabyBlackater@gmail.com", "Burnaby Blackater" },
                    { 43, "YulMoseby@gmail.com", "Yulin Moseby" },
                    { 44, "MilesScruby@gmail.com", "Miles Scruby" },
                    { 45, "JeanineGerren@gmail.com", "Jeanine Gerren" },
                    { 46, "CarmelLendrem@gmail.com", "Carmel Lendrem" },
                    { 47, "AllsunKelleher@gmail.com", "Allsun O' Kelleher" },
                    { 48, "LanitaCrockatt@gmail.com", "Lanita Crockatt" },
                    { 49, "GeorgesLanston@gmail.com", "Georges Lanston" },
                    { 50, "AbbeyPedri@gmail.com", "Abbey Pedrinson" },
                    { 51, "MichealNewtown@gmail.com", "Micheal Newtown" },
                    { 52, "SariChicotti@gmail.com", "Sari Chicotti" },
                    { 53, "GibbieLiggens@gmail.com", "Gibbie Liggens" },
                    { 54, "OdeleSinncock@gmail.com1", "Odele Sinncock" },
                    { 55, "TishaPatey@gmail.com", "Tisha Paterson" },
                    { 56, "MarieleDrinkhall@gmail.com", "Mariele Drinkhall" },
                    { 57, "RaymundClace@gmail.com", "Raymund Clacenson" },
                    { 58, "JoshuahDuckers@gmail.com", "Joshuah Duckers" },
                    { 59, "KelcyViccary@gmail.com", "Kelcy Viccary" },
                    { 60, "KayleePonten@gmail.com", "Kaylee Ponten" },
                    { 61, "MadyViccary@gmail.com", "Mady Viccary" },
                    { 62, "MattieHampton@gmail.com", "Mattie Hampton" },
                    { 63, "KayleeCoushe@gmail.com", "Kaylee Coushe" },
                    { 64, "LucitaRobelet@gmail.com", "Lucita Robelet" },
                    { 65, "FindleyIacoboni@gmail.com", "Findley Iacoboni" },
                    { 66, "AllanWedge@gmail.com", "Allan Wedge" },
                    { 67, "CordeyTremblet@gmail.com", "Cordey Tremblet" },
                    { 68, "GayeSillars@gmail.com", "Gaye Sillars" },
                    { 69, "PieterCurphey@gmail.com", "Pieter Curphey" },
                    { 70, "Ewen-MacDearmont@gmail.com", "Ewen MacDearmont" },
                    { 71, "ignonPennell@gmail.com", "Mignon Pennell" },
                    { 72, "AlanoGeorgot@gmail.com", "Alano Georgot" },
                    { 73, "Alleyouch@gmail.com", "Alley Couch" },
                    { 74, "LiamOffner@gmail.com", "Liam Offner" },
                    { 75, "ElbertinaKleinsinger@gmail.com", "Elbertina Kleinsinger" },
                    { 76, "ElbtinaKlsinger@gmail.com", "Elbtina Klsinger" },
                    { 77, "NoreanSharpless@gmail.com", "Norean Sharpless" },
                    { 78, "VincentsBould@gmail.com", "Vincents Bould" },
                    { 79, "ParkerMcGeorge@gmail.com", "Parker McGeorge" },
                    { 80, "GregoriusMay@gmail.com", "Gregorius May" },
                    { 81, "BevWrigglesworth@gmail.com", "Bev Wrigglesworth" },
                    { 82, "CourtneyGawkes@gmail.com", "Courtney Gawkes" },
                    { 83, "CourtneyMatiasek@gmail.com", "Courtney Matiasek" },
                    { 84, "CoriGunda@gmail.com", "Corine Gunda" },
                    { 85, "MandyScoggin@gmail.com", "Mandy Scoggin" },
                    { 86, "JuanGorry@gmail.com", "Juane Gorrynsen" },
                    { 87, "RandieCridge@gmail.com", "Randie Cridgeno" },
                    { 88, "CourtnayDevoy@gmail.com", "Courtnay Devoy" },
                    { 89, "HavenSeaton@gmail.com", "Haven Seaton" },
                    { 90, "NicolaiSeaborn@gmail.com", "Nicolai Seaborn" },
                    { 91, "MonaCrose@gmail.com", "Mona Crose" },
                    { 92, "AlysonJankowski@gmail.com", "Alyson Jankowski" },
                    { 93, "JeraleeTue@gmail.com", "Jeralee Tue" },
                    { 94, "LonnyCarnachen@gmail.com", "Lonny Carnachen" },
                    { 95, "KoraNichol@gmail.com", "Kora Nichol" },
                    { 96, "KermyBertot@gmail.com", "Kermy Bertot" },
                    { 97, "StanislausBaggallay@gmail.com", "Stanislaus Baggallay" },
                    { 98, "DannySimoneau@gmail.com", "Danny Simoneau" },
                    { 99, "RubinMeaddowcroft@gmail.com", "Rubin Meaddowcroft" },
                    { 100, "MarshaCridge@gmail.com", "Marsha Cridge" },
                    { 101, "ElyshaMaydwell@gmail.com", "Elysha Maydwell" },
                    { 102, "Cridge123@gmail.com", "Cridge1232" },
                    { 103, "MarshaC3456@gmail.com", "Marsha2345" },
                    { 104, "Mardge123@gmail.com", "Marde123" },
                    { 105, "CridgeSe232@gmail.com", "CdSe232" },
                    { 106, "Alexander23@gmail.com", "Axaner23" },
                    { 107, "Janka123@gmail.com", "Janka23" },
                    { 108, "Saxon34@gmail.com", "S" },
                    { 109, "Lob@gmail.com", "Lob" },
                    { 110, "Ge@gmail.com", "Ge" }
                });

            migrationBuilder.InsertData(
                table: "Pilots",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Rating" },
                values: new object[,]
                {
                    { 1, 40, "Alexander", "Jubb", 3.2999999999999998 },
                    { 2, 54, "Cullan", "Geram", 1.5 },
                    { 3, 38, "Germana", "Emburey", 9.1999999999999993 },
                    { 4, 48, "Janka", "Loblie", 7.5 },
                    { 5, 54, "Krystal", "Cuckson", 9.0 },
                    { 6, 42, "Susy", "Borrel", 3.7000000000000002 },
                    { 7, 43, "Saxon", "Veldman", 3.2000000000000002 },
                    { 8, 29, "Lenore", "Romera", 6.9000000000000004 },
                    { 9, 60, "Enrichetta", "Jeremiah", 4.4000000000000004 },
                    { 10, 24, "Delaney", "Stove", 6.9000000000000004 },
                    { 11, 25, "Ilaire", "Tomaszewicz", 7.7999999999999998 },
                    { 12, 36, "Genna", "Jaquet", 4.0 },
                    { 13, 34, "Carlotta", "Dykas", 6.4000000000000004 },
                    { 14, 57, "Viki", "Oneal", 4.9000000000000004 },
                    { 15, 43, "Anthe", "Larne", 7.0999999999999996 },
                    { 16, 45, "Philip", "Penwarden", 3.7000000000000002 },
                    { 17, 38, "Cristi", "Ravenshear", 1.3999999999999999 },
                    { 18, 44, "Louie", "Vogel", 7.4000000000000004 },
                    { 19, 30, "Roddie", "Gribben", 8.0 },
                    { 20, 45, "Boyce", "Briddock", 6.7000000000000002 },
                    { 21, 29, "Heidie", "Blacksell", 3.1000000000000001 },
                    { 22, 22, "Lexie", "Salasar", 9.5 },
                    { 23, 46, "Harmony", "Beincken", 2.2000000000000002 },
                    { 24, 42, "Dick", "Eton", 8.8000000000000007 },
                    { 25, 54, "Philis", "Treswell", 6.7999999999999998 },
                    { 26, 55, "Crosby", "Godlee", 9.5999999999999996 },
                    { 27, 44, "Gerhard", "Alderson", 7.2000000000000002 },
                    { 28, 24, "Dominga", "Cavy", 3.6000000000000001 },
                    { 29, 28, "Judye", "Albrooke", 3.1000000000000001 },
                    { 30, 47, "Felice", "Bartol", 2.1000000000000001 },
                    { 31, 36, "Adolpho", "Wainscot", 4.7000000000000002 },
                    { 32, 49, "Aurilia", "McCready", 1.3999999999999999 },
                    { 33, 37, "Neill", "Woof", 8.5 },
                    { 34, 60, "Rab", "McDarmid", 2.3999999999999999 },
                    { 35, 46, "Ardith", "Kienlein", 9.6999999999999993 },
                    { 36, 56, "Berenice", "Liddiatt", 1.6000000000000001 },
                    { 37, 59, "Ailina", "Sebyer", 8.6999999999999993 },
                    { 38, 22, "Jaynell", "Kidson", 6.2000000000000002 },
                    { 39, 38, "Carina", "Vanyatin", 4.2999999999999998 },
                    { 40, 57, "Edna", "Heatley", 7.5 },
                    { 41, 46, "Hally", "Barthelmes", 8.9000000000000004 },
                    { 42, 40, "Leanna", "Olensby", 4.7999999999999998 },
                    { 43, 23, "Dell", "Willoughey", 6.2999999999999998 },
                    { 44, 33, "Guinevere", "Gras", 6.2999999999999998 },
                    { 45, 21, "Jerrie", "Myles", 1.8 },
                    { 46, 52, "Francoise", "Cusack", 1.1000000000000001 },
                    { 47, 41, "Happy", "Bezant", 8.3000000000000007 },
                    { 48, 58, "Kingsly", "Ianiello", 7.0999999999999996 },
                    { 49, 28, "Leonhard", "Tukely", 5.0999999999999996 },
                    { 50, 21, "Joe", "Waine", 4.4000000000000004 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
