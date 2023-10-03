using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class identityaddednew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "Zhaoguli", "b2fc3a0c-2bbc-4fcb-935a-d5dc19648d61", "wkubach0@nature.com", false, "Male", false, null, null, null, null, null, false, null, false, "ckubach0" },
                    { 2, 0, "Paraíso das Águas", "24fe046f-9035-4088-afb3-dc7325a5e32e", "gmickleburgh1@spotify.com", false, "Male", false, null, null, null, null, null, false, null, false, "jmickleburgh1" },
                    { 3, 0, "Boyarka", "312b2dec-a8c9-4167-81b8-376d3efcd4a0", "gdurante2@state.gov", false, "Male", false, null, null, null, null, null, false, null, false, "wdurante2" },
                    { 4, 0, "Seixal", "76a742d0-f7b7-4804-8175-49d714d616b5", "iwoollett3@yelp.com", false, "Male", false, null, null, null, null, null, false, null, false, "gwoollett3" },
                    { 5, 0, "Saint-Pierre", "33db083c-59fa-4dee-907a-5d6adf2a4c0a", "mwrey4@dot.gov", false, "Female", false, null, null, null, null, null, false, null, false, "awrey4" },
                    { 6, 0, "Teminabuan", "64bef25e-4465-428c-956b-c214058ae9c7", "stimlett5@ihg.com", false, "Female", false, null, null, null, null, null, false, null, false, "mtimlett5" },
                    { 7, 0, "Shuangnian", "75f1e0b1-ac2b-4b20-b2b6-5e19d26f3897", "ltrimbey6@hc360.com", false, "Female", false, null, null, null, null, null, false, null, false, "btrimbey6" },
                    { 8, 0, "Changqing", "1cc3e71e-bb1a-4a20-b24e-7d8ed3f5c8a0", "lgirogetti7@example.com", false, "Female", false, null, null, null, null, null, false, null, false, "cgirogetti7" },
                    { 9, 0, "Eusebio Ayala", "168f5d00-eaac-44f5-96f0-2a117eb06ff2", "rbocken8@nifty.com", false, "Male", false, null, null, null, null, null, false, null, false, "tbocken8" },
                    { 10, 0, "Higashimurayama-shi", "2e72a35c-ab8c-44a2-9a73-44ce072055c6", "dsawer9@netvibes.com", false, "Female", false, null, null, null, null, null, false, null, false, "ssawer9" },
                    { 11, 0, "Las Americas", "854725cd-9ea5-4602-9dc1-97077b9a5593", "pperfecta@goo.ne.jp", false, "Male", false, null, null, null, null, null, false, null, false, "rperfecta" },
                    { 12, 0, "Rantepang", "d8c3bc9e-eccd-4f98-8632-6a07e5496d38", "maxcelb@home.pl", false, "Female", false, null, null, null, null, null, false, null, false, "naxcelb" },
                    { 13, 0, "Dagang", "5142a6c1-d3e1-4c84-864d-8737f9acd7ea", "keykelboschc@joomla.org", false, "Genderqueer", false, null, null, null, null, null, false, null, false, "meykelboschc" },
                    { 14, 0, "Al Qardāḩah", "a546381d-9f70-4554-ab6e-2b15bf124626", "nbamletd@europa.eu", false, "Male", false, null, null, null, null, null, false, null, false, "cbamletd" },
                    { 15, 0, "Dobryanka", "78165757-8235-42b1-86b9-9eccfcd595dc", "sgarritleye@qq.com", false, "Female", false, null, null, null, null, null, false, null, false, "dgarritleye" },
                    { 16, 0, "Rockford", "40f322d1-7cf2-4ff1-b01b-63c8d1e88197", "mlockf@amazon.co.uk", false, "Female", false, null, null, null, null, null, false, null, false, "klockf" },
                    { 17, 0, "Victoria", "d6a3294a-a938-44a1-b4db-17bf472c9328", "rharbachg@hud.gov", false, "Female", false, null, null, null, null, null, false, null, false, "pharbachg" },
                    { 18, 0, "Kamālia", "9a8bb61e-c1a8-4ea5-b75a-f9c0af3cc546", "mtomneyh@zdnet.com", false, "Female", false, null, null, null, null, null, false, null, false, "stomneyh" },
                    { 19, 0, "Erdao", "034fc5b5-8284-436f-a82d-e9ec93835ea9", "mcestardi@g.co", false, "Male", false, null, null, null, null, null, false, null, false, "bcestardi" },
                    { 20, 0, "Holboo", "aafb6c91-7096-46ed-b20b-7cfa9275efc2", "ktopperj@cbc.ca", false, "Female", false, null, null, null, null, null, false, null, false, "rtopperj" },
                    { 21, 0, "Três Coroas", "ecac3ce2-f7e0-4e35-a202-a6befae1d5c8", "mworthyk@deliciousdays.com", false, "Male", false, null, null, null, null, null, false, null, false, "kworthyk" },
                    { 22, 0, "Gibgos", "62174e7a-c256-471a-9fcf-2077b29b914f", "kitscovitzl@go.com", false, "Agender", false, null, null, null, null, null, false, null, false, "mitscovitzl" },
                    { 23, 0, "São João Nepomuceno", "1321a8a1-b7e5-4d52-bd20-cbde14a133ea", "lfitterm@earthlink.net", false, "Female", false, null, null, null, null, null, false, null, false, "sfitterm" },
                    { 24, 0, "Sokolo", "5593cd36-e108-4bdd-a476-bb162b038ca8", "dthorsbyn@xrea.com", false, "Male", false, null, null, null, null, null, false, null, false, "dthorsbyn" },
                    { 25, 0, "Pamplona/Iruña", "9bc805e1-4d03-4a33-aead-5e86456cdfa3", "apeeryo@rakuten.co.jp", false, "Male", false, null, null, null, null, null, false, null, false, "ppeeryo" },
                    { 26, 0, "Telagasari", "19310753-d5ca-4fd2-91de-f55a29ffdd6e", "ftathacottp@nytimes.com", false, "Female", false, null, null, null, null, null, false, null, false, "dtathacottp" },
                    { 27, 0, "Tikhoretsk", "99f3de16-b32a-4fc8-aa44-e782fa55b608", "blingwoodq@jigsy.com", false, "Genderfluid", false, null, null, null, null, null, false, null, false, "mlingwoodq" },
                    { 28, 0, "Rokytne", "a7fcb6a4-042c-4a9b-bd1f-62459568bedf", "jrichesr@tiny.cc", false, "Male", false, null, null, null, null, null, false, null, false, "krichesr" },
                    { 29, 0, "Motuo", "092f712e-9c77-43ab-aa4e-81d284743d8c", "cmaiers@vkontakte.ru", false, "Male", false, null, null, null, null, null, false, null, false, "lmaiers" },
                    { 30, 0, "Smiltene", "00442f7f-3c12-44c3-bf89-6556a7803db6", "pjeannessont@deviantart.com", false, "Female", false, null, null, null, null, null, false, null, false, "ljeannessont" },
                    { 31, 0, "Río Cuarto", "6e239fcf-d61d-47a8-8632-d8b5f25df705", "smolsonu@youku.com", false, "Female", false, null, null, null, null, null, false, null, false, "bmolsonu" },
                    { 32, 0, "Lugui", "6834b92d-cb0c-43b1-ac8a-5f57e281604c", "hgrocockv@bloglines.com", false, "Male", false, null, null, null, null, null, false, null, false, "lgrocockv" },
                    { 33, 0, "Dachnoye", "84960557-4416-45a4-87f7-69dc2a19fa66", "mlessmarew@prnewswire.com", false, "Male", false, null, null, null, null, null, false, null, false, "alessmarew" },
                    { 34, 0, "Modot", "49a9ba6e-0033-4d9d-a711-55b7412bce2b", "jpadfieldx@hud.gov", false, "Male", false, null, null, null, null, null, false, null, false, "cpadfieldx" },
                    { 35, 0, "Marsh Harbour", "7916821b-c94e-463a-a8fd-d009a4f4fc8e", "hhaggerwoody@telegraph.co.uk", false, "Male", false, null, null, null, null, null, false, null, false, "phaggerwoody" },
                    { 36, 0, "Lianzhu", "26089839-7d65-4e44-bf67-b82a24736d4b", "dsandfordz@cnbc.com", false, "Male", false, null, null, null, null, null, false, null, false, "lsandfordz" },
                    { 37, 0, "Hněvotín", "203c1b91-1920-4a81-a63b-321524de53c6", "kboal10@fda.gov", false, "Female", false, null, null, null, null, null, false, null, false, "bboal10" },
                    { 38, 0, "Sydney", "efba8c8a-4cce-4e6d-8410-8c80596d8184", "echalloner11@ucsd.edu", false, "Genderqueer", false, null, null, null, null, null, false, null, false, "gchalloner11" },
                    { 39, 0, "Hechuan", "c8585739-fbf2-4fc0-b8fa-83f54afad8e3", "duzzell12@lulu.com", false, "Male", false, null, null, null, null, null, false, null, false, "luzzell12" },
                    { 40, 0, "Krajan Timur Suger Kidul", "5bb877d7-5ab0-4ab2-b5d4-e1aa84311863", "lcheatle13@simplemachines.org", false, "Female", false, null, null, null, null, null, false, null, false, "ccheatle13" },
                    { 41, 0, "Julayjilah", "198cb810-3cb4-4b9f-8a3d-35bdcf260cd4", "cadamsen14@fema.gov", false, "Male", false, null, null, null, null, null, false, null, false, "aadamsen14" },
                    { 42, 0, "Dębnica Kaszubska", "2b6f08ee-bbca-4c30-81b2-177c56b73580", "jmcilherran15@redcross.org", false, "Genderqueer", false, null, null, null, null, null, false, null, false, "mmcilherran15" },
                    { 43, 0, "Bentar", "94843108-3f5b-4abf-b522-51013fb1b00c", "mcarnock16@ycombinator.com", false, "Female", false, null, null, null, null, null, false, null, false, "bcarnock16" },
                    { 44, 0, "Miaoxi", "7175a1aa-60e1-43ec-8519-52dbff76e3ce", "cderyebarrett17@phpbb.com", false, "Male", false, null, null, null, null, null, false, null, false, "sderyebarrett17" },
                    { 45, 0, "Zengji", "def2a424-7ee9-468f-9f29-2b4ccad706eb", "mcaldwall18@nps.gov", false, "Female", false, null, null, null, null, null, false, null, false, "ccaldwall18" },
                    { 46, 0, "Buawan", "baaa7ee4-2566-490d-8b4a-6ad800b5ea57", "tjosland19@parallels.com", false, "Male", false, null, null, null, null, null, false, null, false, "njosland19" },
                    { 47, 0, "Kajiki", "11e6e53b-c930-4180-aa06-d76c229cc561", "mpetracek1a@feedburner.com", false, "Bigender", false, null, null, null, null, null, false, null, false, "tpetracek1a" },
                    { 48, 0, "Yudaikelike", "598778f7-a2b9-4ad3-b43b-b6127e3a5845", "schisolm1b@sciencedaily.com", false, "Female", false, null, null, null, null, null, false, null, false, "achisolm1b" },
                    { 49, 0, "Casal da Anja", "3443f4f7-72bb-4037-8153-ab632cd7dc49", "ksedgebeer1c@unblog.fr", false, "Female", false, null, null, null, null, null, false, null, false, "ksedgebeer1c" },
                    { 50, 0, "Ararat", "ae6957f7-6050-452b-892f-8dfe1aced60a", "sclubley1d@google.de", false, "Female", false, null, null, null, null, null, false, null, false, "lclubley1d" },
                    { 51, 0, "El Ángel", "d8a5194d-f8e9-4577-82f9-9dc66315d075", "sglassopp1e@opensource.org", false, "Male", false, null, null, null, null, null, false, null, false, "pglassopp1e" },
                    { 52, 0, "Dededo Village", "f5873359-143b-4c8a-81ac-0aec7a890557", "fwilliamson1f@cyberchimps.com", false, "Genderqueer", false, null, null, null, null, null, false, null, false, "awilliamson1f" },
                    { 53, 0, "Zevenaar", "671cbd62-4d64-491d-b678-1ae0e7dcc658", "mvogelein1g@purevolume.com", false, "Male", false, null, null, null, null, null, false, null, false, "kvogelein1g" },
                    { 54, 0, "Topolovgrad", "dccea47d-b52a-416b-b5f0-185c57106059", "ggrigoriscu1h@dagondesign.com", false, "Male", false, null, null, null, null, null, false, null, false, "mgrigoriscu1h" },
                    { 55, 0, "Yuelai", "79628c01-8e80-4091-aa11-b09b6a417be5", "sduffitt1i@usatoday.com", false, "Female", false, null, null, null, null, null, false, null, false, "sduffitt1i" },
                    { 56, 0, "Mencon", "f5e4bba2-f950-410c-b280-8b940cd08855", "trennles1j@earthlink.net", false, "Female", false, null, null, null, null, null, false, null, false, "rrennles1j" },
                    { 57, 0, "Antas", "4274e873-a733-4467-afea-ba00c8c5d978", "mgorler1k@chicagotribune.com", false, "Male", false, null, null, null, null, null, false, null, false, "kgorler1k" },
                    { 58, 0, "Solana", "792fd56a-6bba-4206-8c38-c6e0b021e2e7", "hmacadam1l@berkeley.edu", false, "Male", false, null, null, null, null, null, false, null, false, "kmacadam1l" },
                    { 59, 0, "Maubasa", "a2896e2a-2144-40ed-87b4-01f09cdba0ea", "gshrieve1m@twitpic.com", false, "Male", false, null, null, null, null, null, false, null, false, "ashrieve1m" },
                    { 60, 0, "Tuusula", "30ef8ea2-c134-42d3-bf04-eb8c0b29ef2e", "abottleson1n@nba.com", false, "Male", false, null, null, null, null, null, false, null, false, "cbottleson1n" },
                    { 61, 0, "Bakung Utara", "05d9415b-366d-4379-a75e-5668d3853315", "lknightly1o@chicagotribune.com", false, "Female", false, null, null, null, null, null, false, null, false, "rknightly1o" },
                    { 62, 0, "Ipoh", "bdd4903d-b6a3-493c-98b7-975be4ce7679", "ngingle1p@mashable.com", false, "Male", false, null, null, null, null, null, false, null, false, "kgingle1p" },
                    { 63, 0, "Halmstad", "da3c183c-86b8-4918-85c7-7f95ce0b6a06", "aanthill1q@miibeian.gov.cn", false, "Female", false, null, null, null, null, null, false, null, false, "fanthill1q" },
                    { 64, 0, "Waitun", "05beb465-8fe8-4eb3-b9c9-8021cbe8d02d", "tharsum1r@github.io", false, "Male", false, null, null, null, null, null, false, null, false, "vharsum1r" },
                    { 65, 0, "Lugo", "20e95f24-f98a-4147-94a3-6458dbb9e1bc", "sguido1s@nymag.com", false, "Female", false, null, null, null, null, null, false, null, false, "bguido1s" },
                    { 66, 0, "Las Mesas", "6f31ba98-58a2-4d91-8a26-a685bb65c6d5", "ereuven1t@fema.gov", false, "Male", false, null, null, null, null, null, false, null, false, "preuven1t" },
                    { 67, 0, "Kedungkrajan", "e776ddad-217c-4fb5-8653-87f92206f046", "bmckerlie1u@altervista.org", false, "Male", false, null, null, null, null, null, false, null, false, "cmckerlie1u" },
                    { 68, 0, "Bangelan", "af2afc20-a1a9-4aee-b0b0-30b18c695090", "amorcom1v@soundcloud.com", false, "Female", false, null, null, null, null, null, false, null, false, "amorcom1v" },
                    { 69, 0, "Wonorejo", "111deb7b-bf6a-4a10-9ad7-7169e9b5e8cc", "jmacellen1w@sciencedirect.com", false, "Male", false, null, null, null, null, null, false, null, false, "smacellen1w" },
                    { 70, 0, "Barranco de Loba", "7a70a6dd-7799-4e3b-9aa0-a52e0f8db31f", "msangra1x@soup.io", false, "Male", false, null, null, null, null, null, false, null, false, "vsangra1x" },
                    { 71, 0, "Chendong", "22496f0c-4809-46b1-809c-0513d33cb84f", "hcinelli1y@paypal.com", false, "Male", false, null, null, null, null, null, false, null, false, "ecinelli1y" },
                    { 72, 0, "Fresno", "a2815382-dd9a-4c8a-92aa-a3cd532f387e", "cstace1z@networksolutions.com", false, "Female", false, null, null, null, null, null, false, null, false, "astace1z" },
                    { 73, 0, "Tashtagol", "56108041-4866-4e52-9ee5-7cd7aa91964c", "rpieracci20@moonfruit.com", false, "Female", false, null, null, null, null, null, false, null, false, "dpieracci20" },
                    { 74, 0, "Ersekë", "7758e9c7-7dbe-48f8-935e-0dcc94a6d019", "ageorghiou21@icq.com", false, "Male", false, null, null, null, null, null, false, null, false, "cgeorghiou21" },
                    { 75, 0, "Eira da Pedra", "8cb2ae33-12d6-4732-8ede-82f2192673fd", "creal22@sina.com.cn", false, "Female", false, null, null, null, null, null, false, null, false, "mreal22" },
                    { 76, 0, "Hroznětín", "ed412214-0a2d-437e-aa59-73a4f173ebe0", "eheinschke23@icq.com", false, "Non-binary", false, null, null, null, null, null, false, null, false, "wheinschke23" },
                    { 77, 0, "Terter", "6eeb4cbd-4d09-4bf3-a9ce-4edf6f4f9cef", "bmarval24@dell.com", false, "Male", false, null, null, null, null, null, false, null, false, "emarval24" },
                    { 78, 0, "Samara", "ecd5c8d0-f095-4936-a4d3-f6b57314cd12", "jstothard25@hugedomains.com", false, "Female", false, null, null, null, null, null, false, null, false, "istothard25" },
                    { 79, 0, "Jian’ou", "010727fd-db33-4feb-aa74-f9f213960a86", "amedgewick26@meetup.com", false, "Male", false, null, null, null, null, null, false, null, false, "rmedgewick26" },
                    { 80, 0, "Dampit Satu", "679d5be2-38bd-4106-9134-78a2e1e62b38", "mshawl27@bloglovin.com", false, "Genderfluid", false, null, null, null, null, null, false, null, false, "gshawl27" },
                    { 81, 0, "Columbus", "5c385f93-48af-4b78-9c13-f41851d797dd", "csirey28@google.fr", false, "Female", false, null, null, null, null, null, false, null, false, "csirey28" },
                    { 82, 0, "Susanino", "d2f4e03e-15d6-4a69-94a1-eaccbae497a8", "lmeakin29@blinklist.com", false, "Male", false, null, null, null, null, null, false, null, false, "smeakin29" },
                    { 83, 0, "Kuybyshevo", "6ef8e036-0ab1-4cc1-8d1b-910be54378e5", "aalleway2a@blogger.com", false, "Female", false, null, null, null, null, null, false, null, false, "aalleway2a" },
                    { 84, 0, "Koźmin Wielkopolski", "8f459cdb-2b49-4325-878e-34ea41a498c2", "lstempe2b@xinhuanet.com", false, "Male", false, null, null, null, null, null, false, null, false, "mstempe2b" },
                    { 85, 0, "Iles", "a890c52a-c128-44fc-a016-65197e03381b", "dspellar2c@e-recht24.de", false, "Male", false, null, null, null, null, null, false, null, false, "aspellar2c" },
                    { 86, 0, "San José de Barlovento", "d051c1d3-7ae8-4d55-addf-68882ae77d51", "hsynnot2d@typepad.com", false, "Male", false, null, null, null, null, null, false, null, false, "asynnot2d" },
                    { 87, 0, "Las Vegas", "98f56e03-19e5-436f-af42-2a91e97a5404", "kkelsell2e@w3.org", false, "Female", false, null, null, null, null, null, false, null, false, "kkelsell2e" },
                    { 88, 0, "Al Ma‘baţlī", "738a05be-0c44-49d5-8b2a-8cfd31045534", "ygildea2f@msu.edu", false, "Female", false, null, null, null, null, null, false, null, false, "lgildea2f" },
                    { 89, 0, "San Juan", "e1487b3f-2954-4eb1-b5f7-c6140e90ef1f", "ccoraini2g@forbes.com", false, "Male", false, null, null, null, null, null, false, null, false, "ncoraini2g" },
                    { 90, 0, "Mandala", "2a4b3090-7845-482c-8b30-87e6d92b938c", "srobertazzi2h@stanford.edu", false, "Female", false, null, null, null, null, null, false, null, false, "crobertazzi2h" },
                    { 91, 0, "Didi Lilo", "61ef5db3-b2da-4d67-86e1-c1fbd5141f72", "aroache2i@miitbeian.gov.cn", false, "Male", false, null, null, null, null, null, false, null, false, "hroache2i" },
                    { 92, 0, "Piedecuesta", "3d4d314e-2f94-467c-81d6-1dc765ca1aea", "wkilshall2j@ycombinator.com", false, "Female", false, null, null, null, null, null, false, null, false, "pkilshall2j" },
                    { 93, 0, "Coronda", "27005127-9fd1-4d49-a2ea-6c4dfbe52586", "bperris2k@infoseek.co.jp", false, "Female", false, null, null, null, null, null, false, null, false, "eperris2k" },
                    { 94, 0, "La Mesa", "8931c5c0-c751-4c34-8afe-50e3e56c14d5", "dvarndall2l@technorati.com", false, "Male", false, null, null, null, null, null, false, null, false, "fvarndall2l" },
                    { 95, 0, "Bobon", "b805b5a5-c506-4394-b7a4-e97786fa4417", "nnieass2m@discovery.com", false, "Male", false, null, null, null, null, null, false, null, false, "knieass2m" },
                    { 96, 0, "Kemlya", "52567716-2428-4f03-8033-de56b5a3dd48", "akloisner2n@berkeley.edu", false, "Male", false, null, null, null, null, null, false, null, false, "kkloisner2n" },
                    { 97, 0, "Leipzig", "6c55b206-c5dd-4a5a-89ce-a595564bb4fc", "gmorforth2o@cafepress.com", false, "Male", false, null, null, null, null, null, false, null, false, "gmorforth2o" },
                    { 98, 0, "Muricay", "97ba9e8f-4489-4f1d-916f-863326fc0d21", "qcookney2p@statcounter.com", false, "Male", false, null, null, null, null, null, false, null, false, "acookney2p" },
                    { 99, 0, "Strängnäs", "191f9e17-9c10-41b7-aa94-8fd725359d3f", "ehawtin2q@wired.com", false, "Female", false, null, null, null, null, null, false, null, false, "mhawtin2q" },
                    { 100, 0, "Bat Khela", "b3f95c9b-c24a-4f72-bbf5-1f1fded8f336", "khinge2r@trellian.com", false, "Female", false, null, null, null, null, null, false, null, false, "rhinge2r" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
