// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3x3
    {
        [TestCompiler]
        public static void uint3x3_zero()
        {
            TestUtils.AreEqual(uint3x3.zero.c0.x, 0u);
            TestUtils.AreEqual(uint3x3.zero.c0.y, 0u);
            TestUtils.AreEqual(uint3x3.zero.c0.z, 0u);
            TestUtils.AreEqual(uint3x3.zero.c1.x, 0u);
            TestUtils.AreEqual(uint3x3.zero.c1.y, 0u);
            TestUtils.AreEqual(uint3x3.zero.c1.z, 0u);
            TestUtils.AreEqual(uint3x3.zero.c2.x, 0u);
            TestUtils.AreEqual(uint3x3.zero.c2.y, 0u);
            TestUtils.AreEqual(uint3x3.zero.c2.z, 0u);
        }

        [TestCompiler]
        public static void uint3x3_identity()
        {
            TestUtils.AreEqual(uint3x3.identity.c0.x, 1u);
            TestUtils.AreEqual(uint3x3.identity.c0.y, 0u);
            TestUtils.AreEqual(uint3x3.identity.c0.z, 0u);
            TestUtils.AreEqual(uint3x3.identity.c1.x, 0u);
            TestUtils.AreEqual(uint3x3.identity.c1.y, 1u);
            TestUtils.AreEqual(uint3x3.identity.c1.z, 0u);
            TestUtils.AreEqual(uint3x3.identity.c2.x, 0u);
            TestUtils.AreEqual(uint3x3.identity.c2.y, 0u);
            TestUtils.AreEqual(uint3x3.identity.c2.z, 1u);
        }

        [TestCompiler]
        public static void uint3x3_operator_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(790229414, 970783976, 1428432738, 1578747135, 1733797753, 2001507228, 1446876437, 1777406370, 1426387268);
            uint3x3 b0 = uint3x3(612337669, 1214209108, 2120643427, 295461214, 1510890331, 1893316566, 921816149, 1834958575, 1482011863);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(1809275021, 1843770816, 1172185222, 1469608940, 869874758, 458603090, 581282460, 1948324909, 1129078206);
            uint3x3 b1 = uint3x3(2062852792, 226398742, 770290735, 36812057, 543224481, 1565350150, 1909926604, 1619900436, 1849990483);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(1638391029, 1135553683, 2079295200, 576232476, 608208235, 11172509, 1025529486, 2095601864, 193500113);
            uint3x3 b2 = uint3x3(1261604411, 161864811, 843379453, 1780425458, 215681636, 2123130580, 708665810, 1902328998, 1808456602);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(1780908384, 1587636094, 1892083815, 1250768669, 1984341771, 929607871, 2092475304, 1940221590, 196567546);
            uint3x3 b3 = uint3x3(563830672, 200493241, 1391620681, 1035522654, 168447603, 91580624, 1974459648, 2074899534, 164782857);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1211464300, 1921862607, 508076684, 1249127920, 1394594555, 746862310, 1733655277, 1884008277, 1682018538);
            uint b0 = (746972502);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(795585660, 927605411, 672785749, 1465584610, 585324157, 404448210, 969511077, 442746747, 1772925698);
            uint b1 = (936027116);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(1884034177, 425476075, 1370577708, 597010220, 1249636005, 211986678, 1305479811, 255635293, 1150443719);
            uint b2 = (451512860);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(177122433, 1442445694, 667984966, 1684122010, 1962874832, 172230876, 496695881, 955604291, 872759249);
            uint b3 = (511346787);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_equal_scalar_wide()
        {
            uint a0 = (1150044438);
            uint3x3 b0 = uint3x3(233855098, 924242519, 1402948791, 601381975, 2120518068, 629187703, 1971977031, 47183124, 1061805787);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1009011238);
            uint3x3 b1 = uint3x3(312511148, 1460673064, 737210539, 1737844479, 1892405453, 2133024000, 455818693, 2003197687, 1276241219);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (534746610);
            uint3x3 b2 = uint3x3(559824292, 1758388240, 1023494292, 719963017, 1883763832, 597498209, 367814403, 1839429063, 223575614);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (79701214);
            uint3x3 b3 = uint3x3(1699606118, 759455864, 2017599457, 1395605233, 1191785903, 1156248212, 338891967, 61410415, 1576985758);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_not_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(1660932106, 982847023, 97046264, 1739517447, 1253499180, 1830584069, 1841470429, 1397841646, 1770890135);
            uint3x3 b0 = uint3x3(107139049, 75478496, 2055495054, 358586687, 942338347, 111564990, 113811950, 948912488, 1080084121);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(1906548631, 169082967, 2099271786, 1909317609, 46519139, 1433204003, 931492669, 670504132, 1551558665);
            uint3x3 b1 = uint3x3(1400504872, 1032134499, 1061123400, 221862069, 858950046, 989094643, 2023070999, 1269317127, 531883744);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(1204055048, 1623586740, 226381077, 1145987803, 644253929, 475189890, 922313145, 2006448607, 1574579050);
            uint3x3 b2 = uint3x3(687761409, 278427731, 296354221, 536981557, 1134676193, 1749879634, 1944210269, 92849031, 164029425);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(1839580033, 155350910, 313644534, 2008975915, 1072866331, 10845678, 1588544505, 709736932, 1892341087);
            uint3x3 b3 = uint3x3(628797607, 2069207270, 2022667842, 880567401, 264404537, 1954996717, 572153302, 865957902, 1083128726);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_not_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(747758183, 1033001286, 1439973882, 2138928797, 1197845089, 1432672459, 950170763, 238704450, 2105962247);
            uint b0 = (248693828);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(727205263, 276313906, 2126300423, 791998981, 2035077187, 1171827730, 1412347883, 1622176923, 768370497);
            uint b1 = (1640688041);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(1072798259, 1497830076, 1582645163, 1876273820, 90244766, 30493685, 904014575, 384643370, 11554610);
            uint b2 = (1808712713);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(2016093187, 1596313927, 363921847, 1555396158, 913218907, 1739138988, 1916670251, 1516209113, 765258490);
            uint b3 = (1515760622);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_not_equal_scalar_wide()
        {
            uint a0 = (2076921066);
            uint3x3 b0 = uint3x3(2037494727, 1989050616, 48833929, 1897435904, 514354517, 1783749164, 364694471, 754315072, 124108032);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1512967900);
            uint3x3 b1 = uint3x3(1178825850, 1854793298, 50286949, 2100802631, 1640811853, 82110247, 472172806, 266984506, 2003668365);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1826089250);
            uint3x3 b2 = uint3x3(1041416160, 356140110, 2057237962, 799920703, 1916347720, 510966350, 572038024, 1936481966, 1366859342);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1775285431);
            uint3x3 b3 = uint3x3(604757336, 1047551607, 1311703338, 676012224, 627370253, 1715733805, 699755913, 1875151666, 358894860);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_wide_wide()
        {
            uint3x3 a0 = uint3x3(1182186063, 415538999, 1667335818, 1566618442, 1166180837, 639095188, 1080836365, 771119973, 928263233);
            uint3x3 b0 = uint3x3(524633529, 1032195686, 760723389, 1505751409, 431962172, 1287906509, 1560084663, 1450178202, 2066166337);
            bool3x3 r0 = bool3x3(false, true, false, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(789225474, 665243110, 1003542034, 1032480172, 1961336172, 923379558, 21210619, 1089772116, 1707633052);
            uint3x3 b1 = uint3x3(1107069023, 1640077524, 2103263105, 684229139, 1234033624, 1278743281, 1953079347, 1228832942, 2082539723);
            bool3x3 r1 = bool3x3(true, true, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(778986024, 158153146, 336715101, 1839141169, 1706859710, 1928438162, 1638101724, 2044698552, 1543260981);
            uint3x3 b2 = uint3x3(1088437561, 1058382082, 207459172, 750531081, 2015788562, 2126542133, 271967348, 1601249324, 1373999400);
            bool3x3 r2 = bool3x3(true, true, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(471462349, 1668575142, 2147199161, 946870864, 582371851, 410751553, 198134393, 1999935258, 671192178);
            uint3x3 b3 = uint3x3(1689592186, 459759541, 983106679, 332584818, 2034921203, 833499488, 1999487070, 836063897, 1987309319);
            bool3x3 r3 = bool3x3(true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_wide_scalar()
        {
            uint3x3 a0 = uint3x3(608447185, 818840405, 869219329, 2080125385, 1214500548, 1361741203, 1667165786, 1615392341, 840091491);
            uint b0 = (1491216667);
            bool3x3 r0 = bool3x3(true, true, true, false, true, true, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(469591900, 315321650, 930950514, 1100560246, 933855388, 908563901, 1127696709, 1286331950, 380753337);
            uint b1 = (1247103789);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(971148054, 1056649851, 1579735991, 689044913, 1960894027, 371987110, 867559111, 1703747625, 1698536333);
            uint b2 = (1827886929);
            bool3x3 r2 = bool3x3(true, true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(41716206, 1274625476, 611065092, 118750042, 1829327996, 452204442, 1645191336, 1829152606, 1891059504);
            uint b3 = (243673862);
            bool3x3 r3 = bool3x3(true, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_scalar_wide()
        {
            uint a0 = (548436837);
            uint3x3 b0 = uint3x3(282703327, 14370648, 1862117300, 1304793311, 826073259, 988910157, 445132446, 1139670255, 111349251);
            bool3x3 r0 = bool3x3(false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1102440676);
            uint3x3 b1 = uint3x3(112183144, 1594415311, 1890019295, 2098715503, 608933527, 183989010, 1596056507, 1027318999, 146281093);
            bool3x3 r1 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (358911716);
            uint3x3 b2 = uint3x3(874278078, 1106057699, 1256807459, 2111973919, 1736480659, 810406400, 1329939911, 1276652605, 593690439);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (771851138);
            uint3x3 b3 = uint3x3(590897155, 386688344, 1290583204, 1984930954, 743544838, 1473400608, 1300775973, 1351720916, 168788814);
            bool3x3 r3 = bool3x3(false, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_wide_wide()
        {
            uint3x3 a0 = uint3x3(592884447, 2133928932, 918957182, 1284069471, 194584707, 739120780, 241654068, 1340158550, 2099542537);
            uint3x3 b0 = uint3x3(138737040, 192863971, 1700841444, 1044631301, 1391589821, 730837695, 253553987, 2078872742, 910845808);
            bool3x3 r0 = bool3x3(true, true, false, true, false, true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(1182623667, 1399607274, 789301637, 180400925, 594688333, 1877031463, 1360073500, 1091782422, 546676424);
            uint3x3 b1 = uint3x3(976047676, 202633078, 1223618940, 641600530, 1830470354, 1570701388, 1104256103, 1838646932, 740166101);
            bool3x3 r1 = bool3x3(true, true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(348221770, 716039145, 458742739, 1365508046, 1523167942, 1574478622, 1295065160, 715285504, 1130323487);
            uint3x3 b2 = uint3x3(1549021845, 1457092873, 1790630950, 907793213, 555122804, 1418910265, 335209251, 1094341422, 1465325455);
            bool3x3 r2 = bool3x3(false, false, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(677530432, 1496919050, 12463046, 1106153111, 1315083485, 31516321, 1786538920, 1854361210, 1730650972);
            uint3x3 b3 = uint3x3(390251369, 910309992, 277356652, 1601082764, 771366966, 1782348324, 550490783, 599992449, 550520692);
            bool3x3 r3 = bool3x3(true, true, false, false, true, false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1097138316, 211763648, 1883002501, 56406996, 43662641, 1923456111, 1437755186, 1219010035, 2125058448);
            uint b0 = (438688675);
            bool3x3 r0 = bool3x3(true, false, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(304028799, 48044515, 711945018, 1035679270, 577943770, 572743717, 1016617211, 2063134811, 1577403353);
            uint b1 = (893125636);
            bool3x3 r1 = bool3x3(false, false, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(64009107, 1143565920, 3715845, 689362811, 263973424, 1045140419, 1058332184, 524569092, 1183316983);
            uint b2 = (1462961460);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(1107974092, 523727054, 112709358, 614746280, 1000986708, 1683117650, 1451781409, 61102732, 1284938191);
            uint b3 = (212839726);
            bool3x3 r3 = bool3x3(true, true, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_scalar_wide()
        {
            uint a0 = (2024896938);
            uint3x3 b0 = uint3x3(599356784, 185671342, 1932327391, 2025591013, 1257191721, 1312388500, 1443698859, 779217735, 691047512);
            bool3x3 r0 = bool3x3(true, true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (741776730);
            uint3x3 b1 = uint3x3(732565983, 668302204, 1556466996, 858599525, 1896917159, 701542098, 1052151621, 1023307544, 1435392907);
            bool3x3 r1 = bool3x3(true, true, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1858177345);
            uint3x3 b2 = uint3x3(299897686, 632930355, 1387203601, 483722222, 863042711, 1713088900, 315569296, 292652611, 1002628348);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (927789921);
            uint3x3 b3 = uint3x3(108145064, 425005337, 2093233588, 2063431853, 2079035844, 849337819, 1769234051, 358948261, 267985383);
            bool3x3 r3 = bool3x3(true, true, false, false, false, true, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(1577248162, 2043073061, 1688380407, 176431985, 223299035, 1502802140, 1691709825, 386789394, 117182003);
            uint3x3 b0 = uint3x3(903445031, 2108974565, 210822256, 1281704747, 453681718, 66138830, 1229799377, 1620922595, 1715833766);
            bool3x3 r0 = bool3x3(false, true, false, true, true, false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(1665770435, 1958490731, 420032601, 1251092689, 2011681765, 749743684, 183784440, 1150674774, 1633828822);
            uint3x3 b1 = uint3x3(1366430432, 13102000, 46919981, 486470891, 1709514236, 2145785285, 854254454, 1273278658, 810263315);
            bool3x3 r1 = bool3x3(false, false, false, false, false, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(1719442172, 336047314, 743733218, 1393995865, 1854442658, 1498138884, 912169992, 1992682021, 1619593455);
            uint3x3 b2 = uint3x3(1862773824, 201799013, 974166844, 1320622967, 2058099616, 522102017, 620752145, 1213693681, 1281818305);
            bool3x3 r2 = bool3x3(true, false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(1883313982, 483412430, 857881876, 346624138, 531961063, 269897278, 1062947703, 1743454202, 2048964070);
            uint3x3 b3 = uint3x3(1564146162, 1996153080, 1201909516, 614401396, 224997397, 648547686, 418431167, 1724009726, 401891826);
            bool3x3 r3 = bool3x3(false, true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1722165358, 1219858357, 860410743, 411099660, 348104022, 1963256951, 212084836, 58924407, 1459242706);
            uint b0 = (1688048545);
            bool3x3 r0 = bool3x3(false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(1745758438, 262559763, 690091301, 1806172431, 2091514001, 1857173043, 1617221948, 2017733017, 804204255);
            uint b1 = (532949158);
            bool3x3 r1 = bool3x3(false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(981729559, 910922522, 2079225209, 26179915, 238796519, 1917813750, 1258115260, 20607406, 1337879822);
            uint b2 = (2032949254);
            bool3x3 r2 = bool3x3(true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(959460446, 1279143037, 1551937606, 626254356, 1162369122, 1021674613, 127839058, 1974631244, 426908235);
            uint b3 = (1599429457);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_less_equal_scalar_wide()
        {
            uint a0 = (1777585);
            uint3x3 b0 = uint3x3(1181030049, 1787703989, 1729760948, 1816537388, 1359786460, 874999193, 1678863148, 1711365839, 762067160);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (11953554);
            uint3x3 b1 = uint3x3(1131583906, 1175393186, 1293698493, 48893340, 66196247, 1958607116, 1576473309, 861890786, 478252419);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (957887737);
            uint3x3 b2 = uint3x3(117849810, 1348693584, 105489302, 259034238, 530713566, 601413850, 830430286, 145552297, 1697295044);
            bool3x3 r2 = bool3x3(false, true, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1150680564);
            uint3x3 b3 = uint3x3(2091065664, 1796096704, 1572008712, 1556906486, 205552788, 620963188, 1156705971, 1121867260, 733876180);
            bool3x3 r3 = bool3x3(true, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(263000030, 744235661, 1893760267, 237248, 1062370984, 1676977687, 816766880, 1089431546, 1394493730);
            uint3x3 b0 = uint3x3(1395535146, 1178373944, 1237373760, 1364855321, 600811864, 362060472, 290870624, 1839067862, 396958580);
            bool3x3 r0 = bool3x3(false, false, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(1176473380, 1193988637, 1703862455, 1806186947, 1253571980, 589397635, 1951842887, 798931197, 808426484);
            uint3x3 b1 = uint3x3(1336888643, 1019684398, 1697684196, 1227300220, 2044269675, 1898323839, 874509380, 1873505472, 1268843918);
            bool3x3 r1 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(744869638, 1959531616, 207430702, 1533946595, 1148381840, 2011549474, 605043041, 1707339660, 2038122892);
            uint3x3 b2 = uint3x3(1606949562, 1263896445, 1805518202, 1412091359, 1240330374, 1955056253, 2025187918, 750755999, 869709740);
            bool3x3 r2 = bool3x3(false, true, false, true, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(345761584, 1839156338, 1519670644, 2131285427, 775457686, 796452624, 1710612922, 1629927787, 1094198224);
            uint3x3 b3 = uint3x3(1390799279, 1194035112, 666460047, 103451220, 1311530792, 802468307, 1090745055, 1968071275, 1935027815);
            bool3x3 r3 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(2112791350, 1043657935, 101764761, 1529909067, 556026890, 281734132, 1186600258, 815093894, 609211196);
            uint b0 = (1470533736);
            bool3x3 r0 = bool3x3(true, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(1604309397, 244604867, 1419295004, 471843809, 1819986195, 1460027917, 1646290021, 196833647, 1596738181);
            uint b1 = (829548642);
            bool3x3 r1 = bool3x3(true, false, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(1905036391, 1584946560, 370941146, 440219668, 1607345862, 1449142607, 1223010129, 379014762, 1719435169);
            uint b2 = (1771391775);
            bool3x3 r2 = bool3x3(true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(258833609, 612593660, 42612027, 1138747386, 1491562090, 917503963, 353608194, 1526792895, 192092521);
            uint b3 = (1389585003);
            bool3x3 r3 = bool3x3(false, false, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1525542481);
            uint3x3 b0 = uint3x3(1503244746, 861711266, 817773856, 925984572, 571221723, 683686810, 118252990, 1653952090, 1240253990);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1947039008);
            uint3x3 b1 = uint3x3(1869136019, 152012637, 1214546726, 917376832, 303549425, 2111728811, 945321577, 173706579, 625318949);
            bool3x3 r1 = bool3x3(true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (519443238);
            uint3x3 b2 = uint3x3(1583588379, 1026799433, 1713083717, 394922760, 1216218189, 1336522452, 233894308, 479913036, 984991199);
            bool3x3 r2 = bool3x3(false, false, false, true, false, false, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (172993285);
            uint3x3 b3 = uint3x3(2121050903, 465645173, 788510727, 337378780, 273010835, 1898553615, 1111540136, 717385513, 474197678);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_add_wide_wide()
        {
            uint3x3 a0 = uint3x3(2049228671, 1658660009, 491719392, 937013355, 81108663, 1063894558, 86954702, 843159721, 698977704);
            uint3x3 b0 = uint3x3(2088751567, 645762023, 306868786, 4360271, 506047997, 2094559874, 1634712736, 1601474440, 1586485231);
            uint3x3 r0 = uint3x3(4137980238, 2304422032, 798588178, 941373626, 587156660, 3158454432, 1721667438, 2444634161, 2285462935);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(192867135, 1683407172, 137301303, 2103582820, 526139155, 447937230, 2127411006, 1670579390, 1914969141);
            uint3x3 b1 = uint3x3(908746788, 1812370320, 1247342357, 2043773873, 223363428, 175115707, 985928617, 507662836, 1231457019);
            uint3x3 r1 = uint3x3(1101613923, 3495777492, 1384643660, 4147356693, 749502583, 623052937, 3113339623, 2178242226, 3146426160);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(997691756, 857841794, 2129024875, 267535529, 978891383, 657092366, 941872903, 906908654, 1940071697);
            uint3x3 b2 = uint3x3(776127866, 607782424, 1160366210, 1384832242, 702057048, 703554905, 2106992817, 1994483489, 539473);
            uint3x3 r2 = uint3x3(1773819622, 1465624218, 3289391085, 1652367771, 1680948431, 1360647271, 3048865720, 2901392143, 1940611170);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(862186205, 1951450264, 689662850, 1928213278, 1703906688, 526120638, 423980484, 1867227242, 603782684);
            uint3x3 b3 = uint3x3(236858351, 411317652, 595429166, 713649927, 2053476603, 77965941, 1726775513, 1759186349, 2070333485);
            uint3x3 r3 = uint3x3(1099044556, 2362767916, 1285092016, 2641863205, 3757383291, 604086579, 2150755997, 3626413591, 2674116169);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_add_wide_scalar()
        {
            uint3x3 a0 = uint3x3(2038218457, 134923711, 875689667, 1338884463, 997710928, 340490871, 1067888129, 70433301, 2003021861);
            uint b0 = (2124409227);
            uint3x3 r0 = uint3x3(4162627684, 2259332938, 3000098894, 3463293690, 3122120155, 2464900098, 3192297356, 2194842528, 4127431088);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(1635971971, 85446202, 1068152966, 1239387100, 1497676888, 1727477485, 1095438654, 756559204, 1818718931);
            uint b1 = (1160398286);
            uint3x3 r1 = uint3x3(2796370257, 1245844488, 2228551252, 2399785386, 2658075174, 2887875771, 2255836940, 1916957490, 2979117217);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(658923552, 1585755398, 692843300, 1068593469, 1704776233, 577782260, 736972565, 711894571, 564257439);
            uint b2 = (1610518921);
            uint3x3 r2 = uint3x3(2269442473, 3196274319, 2303362221, 2679112390, 3315295154, 2188301181, 2347491486, 2322413492, 2174776360);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(2051736283, 1628006545, 1855700263, 656748782, 272774516, 1917133199, 828322973, 2116810190, 2092767444);
            uint b3 = (1572837697);
            uint3x3 r3 = uint3x3(3624573980, 3200844242, 3428537960, 2229586479, 1845612213, 3489970896, 2401160670, 3689647887, 3665605141);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_add_scalar_wide()
        {
            uint a0 = (391092078);
            uint3x3 b0 = uint3x3(519908870, 851424292, 328314822, 135622204, 740923360, 655394201, 1451896269, 1781697072, 996031825);
            uint3x3 r0 = uint3x3(911000948, 1242516370, 719406900, 526714282, 1132015438, 1046486279, 1842988347, 2172789150, 1387123903);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1557774949);
            uint3x3 b1 = uint3x3(779774940, 1111541302, 783046445, 1130163944, 288279584, 1397683861, 1636583489, 673263339, 1469300874);
            uint3x3 r1 = uint3x3(2337549889, 2669316251, 2340821394, 2687938893, 1846054533, 2955458810, 3194358438, 2231038288, 3027075823);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (14855965);
            uint3x3 b2 = uint3x3(1116636999, 1488863300, 1600990886, 190651301, 1307459768, 920085839, 2082229835, 1992405574, 1213924458);
            uint3x3 r2 = uint3x3(1131492964, 1503719265, 1615846851, 205507266, 1322315733, 934941804, 2097085800, 2007261539, 1228780423);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (505841452);
            uint3x3 b3 = uint3x3(981421162, 1488337699, 1113826640, 1806146508, 1841791222, 206610851, 526971953, 1236359886, 1459523189);
            uint3x3 r3 = uint3x3(1487262614, 1994179151, 1619668092, 2311987960, 2347632674, 712452303, 1032813405, 1742201338, 1965364641);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_sub_wide_wide()
        {
            uint3x3 a0 = uint3x3(1353441118, 797269833, 659988112, 56022121, 365847472, 2062899435, 1380988474, 799885138, 1306058185);
            uint3x3 b0 = uint3x3(1332656812, 1827794007, 972557431, 2078233689, 1508184327, 1372307701, 810327977, 936799885, 71562303);
            uint3x3 r0 = uint3x3(20784306, 3264443122, 3982397977, 2272755728, 3152630441, 690591734, 570660497, 4158052549, 1234495882);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(579775276, 1239163824, 344591081, 86359575, 1049709943, 721529513, 1767221271, 7652784, 545192611);
            uint3x3 b1 = uint3x3(1418723328, 1971342989, 1226053395, 136565478, 1979903295, 600719425, 837912956, 632054793, 711091688);
            uint3x3 r1 = uint3x3(3456019244, 3562788131, 3413504982, 4244761393, 3364773944, 120810088, 929308315, 3670565287, 4129068219);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(176298787, 1477774126, 1426963688, 2032787858, 2059525977, 445200454, 425848588, 2026967474, 1128492011);
            uint3x3 b2 = uint3x3(904695656, 1640069560, 750244414, 1385118097, 1102391291, 1221949855, 609588723, 1054324682, 1678086165);
            uint3x3 r2 = uint3x3(3566570427, 4132671862, 676719274, 647669761, 957134686, 3518217895, 4111227161, 972642792, 3745373142);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(61421784, 988065731, 1741434432, 2070331135, 1356704176, 1888446703, 1364654917, 265135366, 760501098);
            uint3x3 b3 = uint3x3(1529581776, 1718700085, 523422634, 223602473, 1912611694, 1224986479, 748933681, 88793450, 401362529);
            uint3x3 r3 = uint3x3(2826807304, 3564332942, 1218011798, 1846728662, 3739059778, 663460224, 615721236, 176341916, 359138569);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_sub_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1176369558, 1934521195, 309452150, 1417634074, 108910717, 1306356714, 1502312334, 1451794815, 281174200);
            uint b0 = (462232403);
            uint3x3 r0 = uint3x3(714137155, 1472288792, 4142187043, 955401671, 3941645610, 844124311, 1040079931, 989562412, 4113909093);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(87530840, 2041593336, 557239990, 1119051448, 1590376732, 819090189, 816382635, 815920639, 1829033117);
            uint b1 = (1913724431);
            uint3x3 r1 = uint3x3(2468773705, 127868905, 2938482855, 3500294313, 3971619597, 3200333054, 3197625500, 3197163504, 4210275982);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(1792801932, 1418937976, 1277257189, 2092779398, 642236742, 1605250794, 819644478, 1468003019, 128303186);
            uint b2 = (1113440549);
            uint3x3 r2 = uint3x3(679361383, 305497427, 163816640, 979338849, 3823763489, 491810245, 4001171225, 354562470, 3309829933);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(553494257, 1999744782, 2017272758, 1817991764, 1280985500, 676974855, 1638032613, 949761204, 1835969317);
            uint b3 = (1017126971);
            uint3x3 r3 = uint3x3(3831334582, 982617811, 1000145787, 800864793, 263858529, 3954815180, 620905642, 4227601529, 818842346);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_sub_scalar_wide()
        {
            uint a0 = (1691534405);
            uint3x3 b0 = uint3x3(2022393810, 1612688515, 496689713, 887037586, 2097630964, 374934538, 939035482, 935242277, 1789300421);
            uint3x3 r0 = uint3x3(3964107891, 78845890, 1194844692, 804496819, 3888870737, 1316599867, 752498923, 756292128, 4197201280);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (264712893);
            uint3x3 b1 = uint3x3(1231856067, 1818112748, 1428436109, 1258745460, 1077380396, 1330722719, 518111829, 967128529, 344666254);
            uint3x3 r1 = uint3x3(3327824122, 2741567441, 3131244080, 3300934729, 3482299793, 3228957470, 4041568360, 3592551660, 4215013935);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1082267918);
            uint3x3 b2 = uint3x3(907866696, 1816885123, 460340568, 962154498, 557113461, 1701216709, 1980098777, 730060552, 1444397827);
            uint3x3 r2 = uint3x3(174401222, 3560350091, 621927350, 120113420, 525154457, 3676018505, 3397136437, 352207366, 3932837387);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (853570556);
            uint3x3 b3 = uint3x3(138836432, 1013190428, 718089530, 506757390, 1216448041, 936312747, 1997286455, 1969982026, 902880656);
            uint3x3 r3 = uint3x3(714734124, 4135347424, 135481026, 346813166, 3932089811, 4212225105, 3151251397, 3178555826, 4245657196);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mul_wide_wide()
        {
            uint3x3 a0 = uint3x3(245827027, 208934650, 1019478917, 568231809, 877289039, 1585782440, 2111178729, 1186019069, 571481445);
            uint3x3 b0 = uint3x3(759663997, 350129201, 477450108, 1635735015, 388710278, 757722665, 1509388321, 1841703980, 1826369331);
            uint3x3 r0 = uint3x3(3662155527, 1402281434, 332447596, 2361989735, 2624048730, 1455036648, 2128344329, 3700879228, 2640799263);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(1570087048, 629447153, 619383734, 2055121568, 700402816, 263414349, 187830569, 2048056680, 546694675);
            uint3x3 b1 = uint3x3(1524322467, 1605207974, 428419155, 1460605791, 1968043860, 771161742, 2037340417, 322304267, 651448359);
            uint3x3 r1 = uint3x3(2093463192, 3087460678, 3161406466, 990589280, 3356793344, 2953243830, 1156600361, 649177976, 678952165);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(853585367, 933370718, 990212476, 1915885905, 1984212358, 368146234, 899438811, 1765718681, 409003054);
            uint3x3 b2 = uint3x3(1608326767, 1427155898, 1092185338, 665119139, 223634707, 694718952, 675813713, 999254223, 1326064110);
            uint3x3 r2 = uint3x3(1063621177, 2683284556, 2152538904, 3721713555, 2642853618, 1626072720, 1891467339, 335415735, 1128927428);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(2069758852, 140280263, 442491280, 1924530939, 1372320666, 200879709, 857149632, 962693646, 988118613);
            uint3x3 b3 = uint3x3(788102700, 1927999142, 1706356773, 747671596, 106127297, 1695925670, 1788874462, 534570710, 1110638325);
            uint3x3 r3 = uint3x3(2638713520, 2861115658, 479369680, 3928339236, 4044803354, 48406862, 2297104000, 4019846068, 2811510105);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mul_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1762033447, 465343930, 1570757881, 1326409563, 1824319147, 1356578909, 72749215, 154616909, 975743632);
            uint b0 = (1476837906);
            uint3x3 r0 = uint3x3(2981789374, 1326807828, 2156411778, 4018813542, 4229418502, 2976383114, 2455742766, 2574460778, 1736252960);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(573770299, 971327747, 1818877398, 1324050764, 660611671, 1279757657, 391009467, 1186856590, 890343818);
            uint b1 = (1958912969);
            uint3x3 r1 = uint3x3(3595344211, 583613531, 2609540870, 377032876, 2454084431, 3835667937, 506042323, 3286058878, 2903122778);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(800117742, 1338014500, 1688964615, 1439447294, 387721300, 1192501703, 1613845584, 76318055, 124378112);
            uint b2 = (606927173);
            uint3x3 r2 = uint3x3(3182664998, 4040635572, 1687557859, 1193437814, 1547735716, 2273028515, 2785905040, 1364534211, 3330558976);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(970518733, 1978842602, 1451974062, 987919119, 1659987051, 1325430351, 948943118, 1743760648, 227492421);
            uint b3 = (1370700538);
            uint3x3 r3 = uint3x3(3770718770, 45251204, 2784815084, 28492454, 1649233534, 4185812774, 2668749740, 1373293008, 3727251810);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mul_scalar_wide()
        {
            uint a0 = (99541948);
            uint3x3 b0 = uint3x3(1764461774, 657072478, 1459784358, 1610646683, 1632058826, 868441654, 1408757883, 335917146, 2105124483);
            uint3x3 r0 = uint3x3(3344568648, 4192918280, 1260585960, 1158730452, 4293361240, 3828814248, 2108402516, 1966690328, 1623617844);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1178393968);
            uint3x3 b1 = uint3x3(1963904348, 1409533767, 243286231, 1336308795, 517963367, 1733623488, 459880225, 994616533, 1420531535);
            uint3x3 r1 = uint3x3(1196573760, 592673296, 209320208, 3942500560, 1007302672, 3390780416, 3294337904, 2248146480, 1026909584);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1821413700);
            uint3x3 b2 = uint3x3(677771573, 2132626845, 1158827713, 640102997, 944551639, 1323243330, 1186460236, 657101857, 1275563580);
            uint3x3 r2 = uint3x3(118306580, 1091472052, 1879587908, 2176549780, 4108343324, 1015975816, 1406756912, 3284535748, 3411133424);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (1031291523);
            uint3x3 b3 = uint3x3(1008470115, 1155301041, 1046199281, 2138825098, 1273008873, 1788343477, 1994364082, 597340263, 2022856151);
            uint3x3 r3 = uint3x3(2179584169, 2776004243, 358436435, 3342466462, 469974843, 2393957023, 2519661334, 1424675509, 3838532357);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_div_wide_wide()
        {
            uint3x3 a0 = uint3x3(1590198532, 507812502, 126627032, 1058247011, 427387861, 290676154, 1829594484, 1127868739, 499016351);
            uint3x3 b0 = uint3x3(1434703236, 911965201, 390415521, 128746927, 525835375, 816946613, 878264647, 146789678, 2089524057);
            uint3x3 r0 = uint3x3(1, 0, 0, 8, 0, 0, 2, 7, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(1341209632, 134906097, 785470242, 788249865, 1099825433, 1552968283, 1822367139, 1021812060, 1937073018);
            uint3x3 b1 = uint3x3(254213018, 1916850021, 1737806518, 1906634983, 437754923, 825037958, 902508708, 896853614, 49452028);
            uint3x3 r1 = uint3x3(5, 0, 0, 0, 2, 1, 2, 1, 39);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(645757349, 1097576782, 1246027674, 1152153253, 1900577195, 172149343, 1735128704, 816492592, 2012272185);
            uint3x3 b2 = uint3x3(1921327824, 787000669, 1032149621, 858558868, 1422112429, 837098844, 616122946, 2035322800, 1324534444);
            uint3x3 r2 = uint3x3(0, 1, 1, 1, 1, 0, 2, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(632330092, 649232994, 123715336, 1438073735, 723262291, 850951883, 1942618200, 1088675276, 1648515976);
            uint3x3 b3 = uint3x3(1820832158, 917489631, 367475696, 620492088, 1749833550, 1535651093, 932740870, 1078416711, 725172174);
            uint3x3 r3 = uint3x3(0, 0, 0, 2, 0, 0, 2, 1, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_div_wide_scalar()
        {
            uint3x3 a0 = uint3x3(560951562, 1218680769, 375341724, 1613542090, 1919409166, 1397425408, 1349573078, 524526253, 341995568);
            uint b0 = (947861580);
            uint3x3 r0 = uint3x3(0, 1, 0, 1, 2, 1, 1, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(495895326, 1676971657, 2131487088, 2105094094, 1017891310, 542666029, 1646044372, 1447236569, 107215658);
            uint b1 = (1515313790);
            uint3x3 r1 = uint3x3(0, 1, 1, 1, 0, 0, 1, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(19616726, 707389627, 1249475421, 1486968988, 1738891885, 1919705924, 1244966864, 1200843642, 206442634);
            uint b2 = (896899915);
            uint3x3 r2 = uint3x3(0, 0, 1, 1, 1, 2, 1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(1508567412, 1117255783, 929925156, 1725332114, 1949103348, 1383839785, 2136282541, 159847918, 1515555001);
            uint b3 = (1825701056);
            uint3x3 r3 = uint3x3(0, 0, 0, 0, 1, 0, 1, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_div_scalar_wide()
        {
            uint a0 = (1161272038);
            uint3x3 b0 = uint3x3(187325733, 1594107378, 2016183849, 1589343709, 388768753, 1417077283, 1773486938, 1154044032, 81831373);
            uint3x3 r0 = uint3x3(6, 0, 0, 0, 2, 0, 0, 1, 14);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1476877645);
            uint3x3 b1 = uint3x3(653688843, 45756703, 631027637, 396671391, 784365696, 1250594097, 1818363859, 1653451772, 270557729);
            uint3x3 r1 = uint3x3(2, 32, 2, 3, 1, 1, 0, 0, 5);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (48974453);
            uint3x3 b2 = uint3x3(1796936382, 1427856423, 981056957, 1955700573, 705450043, 1054404890, 351914083, 131970646, 1320586926);
            uint3x3 r2 = uint3x3(0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (366944102);
            uint3x3 b3 = uint3x3(1575786200, 257204865, 1582754309, 2114509003, 1266146708, 45105265, 2092444751, 407744534, 126616016);
            uint3x3 r3 = uint3x3(0, 1, 0, 0, 0, 8, 0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mod_wide_wide()
        {
            uint3x3 a0 = uint3x3(146150818, 1846543305, 1071447756, 308965362, 659881575, 1002365460, 861198439, 1510617532, 778525078);
            uint3x3 b0 = uint3x3(983050390, 771341152, 942375212, 367361754, 749500619, 750718852, 2095151755, 88438806, 769227442);
            uint3x3 r0 = uint3x3(146150818, 303861001, 129072544, 308965362, 659881575, 251646608, 861198439, 7157830, 9297636);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(1458458044, 101987897, 1249565173, 938026607, 1692541775, 1518877124, 1806965510, 1325139851, 994457255);
            uint3x3 b1 = uint3x3(647214624, 1026513788, 1544950956, 160166322, 1099108075, 1158422232, 1798905209, 164686701, 327889784);
            uint3x3 r1 = uint3x3(164028796, 101987897, 1249565173, 137194997, 593433700, 360454892, 8060301, 7646243, 10787903);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(1372400564, 1770508529, 100255877, 452674793, 1545968777, 629019189, 1402964707, 2138294579, 1641714420);
            uint3x3 b2 = uint3x3(1082162785, 1213537518, 608481038, 329133821, 1824387961, 1223426748, 798137669, 79717779, 1233582258);
            uint3x3 r2 = uint3x3(290237779, 556971011, 100255877, 123540972, 1545968777, 629019189, 604827038, 65632325, 408132162);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(1782022072, 1880968864, 1980798192, 1397317084, 995968277, 1090018756, 1573062648, 1100694500, 863521889);
            uint3x3 b3 = uint3x3(1267120677, 301592349, 911281434, 1357340934, 1648942990, 1350943898, 696511738, 1182727748, 1843845940);
            uint3x3 r3 = uint3x3(514901395, 71414770, 158235324, 39976150, 995968277, 1090018756, 180039172, 1100694500, 863521889);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mod_wide_scalar()
        {
            uint3x3 a0 = uint3x3(164800505, 1062177828, 1898749675, 1701653318, 820393245, 19002208, 128329633, 1464010899, 896587769);
            uint b0 = (883951171);
            uint3x3 r0 = uint3x3(164800505, 178226657, 130847333, 817702147, 820393245, 19002208, 128329633, 580059728, 12636598);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(405208598, 959236935, 712321026, 172564850, 1540068445, 1085897743, 1607489717, 165478511, 647846716);
            uint b1 = (1982762194);
            uint3x3 r1 = uint3x3(405208598, 959236935, 712321026, 172564850, 1540068445, 1085897743, 1607489717, 165478511, 647846716);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(915707999, 928191283, 1084934806, 488509689, 2087820912, 377501313, 1778384846, 1216011754, 812183417);
            uint b2 = (1602830401);
            uint3x3 r2 = uint3x3(915707999, 928191283, 1084934806, 488509689, 484990511, 377501313, 175554445, 1216011754, 812183417);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(1153802502, 1924710742, 665297470, 1568090825, 2050982942, 435886407, 453990946, 1731665372, 586777590);
            uint b3 = (1642671870);
            uint3x3 r3 = uint3x3(1153802502, 282038872, 665297470, 1568090825, 408311072, 435886407, 453990946, 88993502, 586777590);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_mod_scalar_wide()
        {
            uint a0 = (242383789);
            uint3x3 b0 = uint3x3(740000543, 1556450291, 1104736385, 437976569, 1911837205, 1507212038, 1906405167, 247693265, 293460573);
            uint3x3 r0 = uint3x3(242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1495295166);
            uint3x3 b1 = uint3x3(873323603, 530681233, 1298102643, 2057984657, 1000742091, 1461372131, 1859742342, 797184687, 821888842);
            uint3x3 r1 = uint3x3(621971563, 433932700, 197192523, 1495295166, 494553075, 33923035, 1495295166, 698110479, 673406324);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1083192997);
            uint3x3 b2 = uint3x3(840114986, 1894865954, 615159964, 1485575122, 2028738, 2122220318, 164578061, 730088119, 1444946139);
            uint3x3 r2 = uint3x3(243078011, 1083192997, 468033033, 1083192997, 1875643, 1083192997, 95724631, 353104878, 1083192997);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1305792037);
            uint3x3 b3 = uint3x3(1110829011, 872723581, 166847388, 1477846418, 511428733, 1642227542, 1962310765, 207128894, 1342085447);
            uint3x3 r3 = uint3x3(194963026, 433068456, 137860321, 1305792037, 282934571, 1305792037, 1305792037, 63018673, 1305792037);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_plus()
        {
            uint3x3 a0 = uint3x3(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897);
            uint3x3 r0 = uint3x3(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897);
            TestUtils.AreEqual(+a0, r0);

            uint3x3 a1 = uint3x3(1287765427, 174532915, 1864850812, 1566098441, 1145639744, 1615499926, 2049663954, 1723005749, 409076474);
            uint3x3 r1 = uint3x3(1287765427, 174532915, 1864850812, 1566098441, 1145639744, 1615499926, 2049663954, 1723005749, 409076474);
            TestUtils.AreEqual(+a1, r1);

            uint3x3 a2 = uint3x3(591286416, 1079164488, 1808261782, 1201290141, 82958939, 308695413, 1575280693, 2067379018, 1673126612);
            uint3x3 r2 = uint3x3(591286416, 1079164488, 1808261782, 1201290141, 82958939, 308695413, 1575280693, 2067379018, 1673126612);
            TestUtils.AreEqual(+a2, r2);

            uint3x3 a3 = uint3x3(500666137, 836003812, 336058393, 829347661, 33442669, 381670450, 277507230, 361395485, 1012749225);
            uint3x3 r3 = uint3x3(500666137, 836003812, 336058393, 829347661, 33442669, 381670450, 277507230, 361395485, 1012749225);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_neg()
        {
            uint3x3 a0 = uint3x3(1955022112, 662160019, 370300775, 2141283773, 1004505619, 28153593, 33894270, 505708349, 1115028238);
            uint3x3 r0 = uint3x3(2339945184, 3632807277, 3924666521, 2153683523, 3290461677, 4266813703, 4261073026, 3789258947, 3179939058);
            TestUtils.AreEqual(-a0, r0);

            uint3x3 a1 = uint3x3(1636274969, 1542206286, 213087293, 243937487, 341522275, 841085242, 574159094, 1687250035, 2057919693);
            uint3x3 r1 = uint3x3(2658692327, 2752761010, 4081880003, 4051029809, 3953445021, 3453882054, 3720808202, 2607717261, 2237047603);
            TestUtils.AreEqual(-a1, r1);

            uint3x3 a2 = uint3x3(1175014732, 1212465326, 1190569920, 2047955772, 2120729864, 1440774928, 1485596454, 431666091, 1387601718);
            uint3x3 r2 = uint3x3(3119952564, 3082501970, 3104397376, 2247011524, 2174237432, 2854192368, 2809370842, 3863301205, 2907365578);
            TestUtils.AreEqual(-a2, r2);

            uint3x3 a3 = uint3x3(1745651998, 1119959806, 739132284, 1954173314, 1709857098, 1836511050, 1662806453, 506144868, 650922971);
            uint3x3 r3 = uint3x3(2549315298, 3175007490, 3555835012, 2340793982, 2585110198, 2458456246, 2632160843, 3788822428, 3644044325);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_prefix_inc()
        {
            uint3x3 a0 = uint3x3(864455342, 2035793213, 1275443862, 971919915, 411610189, 446210725, 395072276, 115573442, 913293639);
            uint3x3 r0 = uint3x3(864455343, 2035793214, 1275443863, 971919916, 411610190, 446210726, 395072277, 115573443, 913293640);
            TestUtils.AreEqual(++a0, r0);

            uint3x3 a1 = uint3x3(432884105, 1385544935, 1835605516, 831396561, 388229350, 696475402, 1786514683, 993189311, 752093909);
            uint3x3 r1 = uint3x3(432884106, 1385544936, 1835605517, 831396562, 388229351, 696475403, 1786514684, 993189312, 752093910);
            TestUtils.AreEqual(++a1, r1);

            uint3x3 a2 = uint3x3(1622410417, 241906003, 1705625817, 609525897, 172599489, 504806865, 519296647, 281942776, 1541894135);
            uint3x3 r2 = uint3x3(1622410418, 241906004, 1705625818, 609525898, 172599490, 504806866, 519296648, 281942777, 1541894136);
            TestUtils.AreEqual(++a2, r2);

            uint3x3 a3 = uint3x3(924683935, 1349062584, 1120518661, 65514038, 1495168208, 1321109497, 1366348660, 1777734111, 1414867743);
            uint3x3 r3 = uint3x3(924683936, 1349062585, 1120518662, 65514039, 1495168209, 1321109498, 1366348661, 1777734112, 1414867744);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_postfix_inc()
        {
            uint3x3 a0 = uint3x3(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607);
            uint3x3 r0 = uint3x3(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607);
            TestUtils.AreEqual(a0++, r0);

            uint3x3 a1 = uint3x3(708474528, 1524860667, 1408994706, 375284401, 1580130369, 1676086778, 717006530, 506142468, 732199129);
            uint3x3 r1 = uint3x3(708474528, 1524860667, 1408994706, 375284401, 1580130369, 1676086778, 717006530, 506142468, 732199129);
            TestUtils.AreEqual(a1++, r1);

            uint3x3 a2 = uint3x3(2026873940, 1513142653, 420613464, 1219979307, 586574160, 357567451, 1468020171, 1949784665, 1127356901);
            uint3x3 r2 = uint3x3(2026873940, 1513142653, 420613464, 1219979307, 586574160, 357567451, 1468020171, 1949784665, 1127356901);
            TestUtils.AreEqual(a2++, r2);

            uint3x3 a3 = uint3x3(101238629, 423320704, 827539403, 1919960927, 840371710, 2010345998, 1047836590, 586887730, 1209169651);
            uint3x3 r3 = uint3x3(101238629, 423320704, 827539403, 1919960927, 840371710, 2010345998, 1047836590, 586887730, 1209169651);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_prefix_dec()
        {
            uint3x3 a0 = uint3x3(200904609, 871077500, 968578728, 638967721, 1995396216, 435367037, 1782514098, 1589827826, 1434377580);
            uint3x3 r0 = uint3x3(200904608, 871077499, 968578727, 638967720, 1995396215, 435367036, 1782514097, 1589827825, 1434377579);
            TestUtils.AreEqual(--a0, r0);

            uint3x3 a1 = uint3x3(596759698, 1758478358, 1914114460, 71237375, 389120307, 1022184392, 1310293956, 356565557, 18299409);
            uint3x3 r1 = uint3x3(596759697, 1758478357, 1914114459, 71237374, 389120306, 1022184391, 1310293955, 356565556, 18299408);
            TestUtils.AreEqual(--a1, r1);

            uint3x3 a2 = uint3x3(906734601, 1383897383, 1040798388, 1469596990, 1719228297, 220897829, 1454322707, 678025545, 14227726);
            uint3x3 r2 = uint3x3(906734600, 1383897382, 1040798387, 1469596989, 1719228296, 220897828, 1454322706, 678025544, 14227725);
            TestUtils.AreEqual(--a2, r2);

            uint3x3 a3 = uint3x3(293093918, 1249415499, 1009503100, 157482354, 965385343, 1797304434, 1083672612, 929765380, 2083512379);
            uint3x3 r3 = uint3x3(293093917, 1249415498, 1009503099, 157482353, 965385342, 1797304433, 1083672611, 929765379, 2083512378);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_postfix_dec()
        {
            uint3x3 a0 = uint3x3(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285);
            uint3x3 r0 = uint3x3(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285);
            TestUtils.AreEqual(a0--, r0);

            uint3x3 a1 = uint3x3(2017728859, 377162390, 526366486, 1504625034, 590919177, 60677868, 1867810045, 2095777993, 670715645);
            uint3x3 r1 = uint3x3(2017728859, 377162390, 526366486, 1504625034, 590919177, 60677868, 1867810045, 2095777993, 670715645);
            TestUtils.AreEqual(a1--, r1);

            uint3x3 a2 = uint3x3(324944916, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208, 1931943579, 175622377);
            uint3x3 r2 = uint3x3(324944916, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208, 1931943579, 175622377);
            TestUtils.AreEqual(a2--, r2);

            uint3x3 a3 = uint3x3(181847458, 530897466, 635466911, 416440036, 1447690298, 1444496274, 296146626, 1209855130, 2016700604);
            uint3x3 r3 = uint3x3(181847458, 530897466, 635466911, 416440036, 1447690298, 1444496274, 296146626, 1209855130, 2016700604);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_and_wide_wide()
        {
            uint3x3 a0 = uint3x3(779935043, 1097962163, 1939593304, 800599247, 952140918, 782792558, 1608557706, 396446406, 2039894114);
            uint3x3 b0 = uint3x3(307705143, 1710882162, 866836769, 532490608, 679371720, 1794035877, 1439832202, 519529812, 23633139);
            uint3x3 r0 = uint3x3(39064835, 1097961522, 864731136, 263727168, 675283008, 715673636, 1438646410, 379666500, 16781410);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(1286974642, 442394124, 1759739564, 233435438, 665207770, 1942050241, 1022352952, 60340400, 329119345);
            uint3x3 b1 = uint3x3(1209152681, 646737179, 1255867027, 1900854122, 413173763, 1409138251, 2087190272, 563439483, 354579077);
            uint3x3 r1 = uint3x3(1209017504, 34366472, 1220739712, 21541162, 10485762, 1405162561, 1013440000, 26222640, 285241857);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(406517382, 1126764634, 343425836, 1957552749, 1624478957, 341972372, 181537307, 130347414, 1240828622);
            uint3x3 b2 = uint3x3(642224854, 1650432515, 755290290, 902865191, 661389406, 2134212586, 1855189321, 185194029, 810374380);
            uint3x3 r2 = uint3x3(168582, 1107890178, 67125280, 880844837, 541065292, 337646976, 177340425, 50384900, 4522188);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(526120460, 695449226, 1477446724, 201628999, 737924014, 1804502415, 1733695477, 1110712857, 113012430);
            uint3x3 b3 = uint3x3(133197864, 1989578783, 38739182, 387425484, 1690486314, 843085933, 1045118223, 41867329, 1397669260);
            uint3x3 r3 = uint3x3(122712072, 538087434, 3140, 67404868, 549634602, 570425357, 641864965, 36962305, 34352268);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_and_wide_scalar()
        {
            uint3x3 a0 = uint3x3(443615469, 490057985, 2042441263, 1524760558, 1405175110, 510212004, 1941875181, 1236735839, 1365509729);
            uint b0 = (93423598);
            uint3x3 r0 = uint3x3(1114348, 85033216, 26281518, 8488942, 25232710, 67176356, 26247660, 26281806, 16778848);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(428270198, 650270920, 1249238550, 814629680, 1862276471, 143502472, 861733033, 1408932942, 957693145);
            uint b1 = (607982857);
            uint3x3 r1 = uint3x3(262144, 603983880, 3478528, 537657600, 603985153, 853000, 538771465, 3675144, 538252297);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(1567715668, 322053683, 1599352836, 208656708, 1272226025, 462670926, 1817145060, 1466722981, 1817277774);
            uint b2 = (1102952410);
            uint3x3 r2 = uint3x3(1093742928, 19932690, 1091842048, 2986304, 1100259528, 26313802, 1074603712, 1093411456, 1074869578);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(818900583, 1630437952, 546018772, 872875431, 1143080525, 708719245, 1764446048, 1527981061, 398141788);
            uint b3 = (772681077);
            uint3x3 r3 = uint3x3(537799781, 537788480, 537527636, 604374309, 67241029, 705568773, 671747424, 167912453, 101329236);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1144543590);
            uint3x3 b0 = uint3x3(420346723, 562416448, 1393127318, 1560699552, 851218057, 703880958, 1159378889, 2031211279, 1089518981);
            uint3x3 r0 = uint3x3(547170, 18752, 1074284806, 1140867104, 3672064, 3168358, 1142427968, 1074811142, 1076893956);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (270607307);
            uint3x3 b1 = uint3x3(1349288930, 520199596, 1763483957, 1248975349, 236938635, 185023291, 1085233038, 1845693112, 946052961);
            uint3x3 r1 = uint3x3(270533570, 268501384, 8449, 2163137, 74123, 74507, 2163594, 66184, 270598977);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1436238522);
            uint3x3 b2 = uint3x3(2042776519, 56356886, 1770159840, 1872339579, 1439201366, 1233066417, 1214109404, 2255485, 1814885263);
            uint3x3 r2 = uint3x3(1367491202, 18563090, 1099055776, 1167655482, 1434992658, 1092288688, 1075397272, 148024, 1141392010);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1711986588);
            uint3x3 b3 = uint3x3(1286898282, 915476451, 1870138851, 372814411, 1623486506, 211665304, 1668985777, 348112007, 1808619374);
            uint3x3 r3 = uint3x3(1140883976, 637536128, 1711801728, 101224968, 1610633224, 67682712, 1644860304, 67814532, 1644713740);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_or_wide_wide()
        {
            uint3x3 a0 = uint3x3(1731159103, 659068416, 382702471, 1821032196, 1565773438, 1004000514, 948501377, 600951835, 669346222);
            uint3x3 b0 = uint3x3(1583847161, 692672727, 1161585489, 1756207130, 1321374429, 1287357212, 2075767170, 1273513430, 1610830169);
            uint3x3 r0 = uint3x3(2138044159, 793370327, 1476391895, 1823457054, 1607720703, 2147473182, 2075786115, 1811533279, 1743223295);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(396691477, 2108560248, 2117522137, 330307355, 818676817, 1774459567, 1117506257, 1254511182, 1017865993);
            uint3x3 b1 = uint3x3(1316929125, 511625048, 573925879, 1502255628, 1841676448, 1682928938, 1115131952, 1541423910, 1416096228);
            uint3x3 r1 = uint3x3(1610595957, 2147407736, 2117598207, 1538957087, 2110637297, 1842315183, 1124063985, 1541821294, 2096099309);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(1883021644, 1140203470, 759288967, 2122744307, 335621148, 715028074, 543305337, 662107399, 1934997335);
            uint3x3 b2 = uint3x3(188606371, 1041599540, 219545389, 560097663, 1087543661, 936383841, 108816721, 1694053551, 452638547);
            uint3x3 r2 = uint3x3(2067654639, 2146934782, 760610735, 2145839615, 1423162749, 1071544171, 645820281, 1744827823, 2080356183);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(436754869, 1613808671, 362365372, 342908672, 2129231210, 203868172, 32846030, 1057901177, 1537975433);
            uint3x3 b3 = uint3x3(1219534055, 85142537, 1027930490, 2126839395, 2030328147, 2036352209, 1554561114, 1332339254, 480739851);
            uint3x3 r3 = uint3x3(1522064887, 1697901599, 1037957630, 2129985379, 2146270587, 2103889117, 1576909022, 2138040959, 1605346955);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_or_wide_scalar()
        {
            uint3x3 a0 = uint3x3(961259683, 471103264, 1733389229, 1591585258, 386953869, 1148351449, 1048929715, 1814263250, 860336789);
            uint b0 = (1666102508);
            uint3x3 r0 = uint3x3(2068823279, 2136930284, 1734344685, 2145369582, 2002712301, 1736374269, 2144335359, 1869608446, 1934604029);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(1637162093, 774029856, 879300408, 1179087439, 797240690, 1977614655, 46921989, 1980838747, 284225881);
            uint b1 = (1227888278);
            uint3x3 r1 = uint3x3(1773477631, 1865602742, 2105089982, 1333229279, 1874132982, 2112886719, 1274806167, 2133931999, 1508964319);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(64304104, 1393862490, 1890090886, 521303722, 2021379070, 2055963359, 1511253082, 1775629833, 1142751163);
            uint b2 = (313591807);
            uint3x3 r2 = uint3x3(334837759, 1404413951, 1924759551, 531855359, 2063323135, 2059110399, 1521739775, 2079717375, 1455292415);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(1767274359, 1501294791, 485944015, 539526284, 310877895, 1815369493, 529427586, 358352200, 1353013374);
            uint b3 = (1421981808);
            uint3x3 r3 = uint3x3(2111307639, 1576794359, 1559755519, 1961475324, 1455931127, 2096496501, 1607466226, 1440595320, 1424357502);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1213433101);
            uint3x3 b0 = uint3x3(1212928242, 1614462616, 936937728, 764766995, 306352095, 574719481, 1283571271, 2109131012, 979469710);
            uint3x3 r0 = uint3x3(1213978111, 1752940445, 2145094925, 1842867999, 1515425759, 1783858685, 1288945487, 2113391885, 2054391183);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1348323481);
            uint3x3 b1 = uint3x3(1407542578, 697517649, 1059093741, 627815046, 418822515, 83214352, 424663473, 447949225, 527022375);
            uint3x3 r1 = uint3x3(1409150395, 2044710617, 2138963197, 1971321503, 1493170683, 1425918105, 1499453881, 1526720953, 1602091455);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1947148461);
            uint3x3 b2 = uint3x3(305251437, 1254601325, 1752329425, 1592402684, 1587055329, 1088734150, 298563808, 2052547661, 582843231);
            uint3x3 r2 = uint3x3(1983898861, 2127540973, 2088725757, 2129601277, 2124393197, 1961878511, 1976547565, 2120180973, 1992260607);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (656983670);
            uint3x3 b3 = uint3x3(1944993640, 1081208038, 829763560, 990961386, 547309556, 1307122961, 263229121, 1518227598, 1098359242);
            uint3x3 r3 = uint3x3(2012151678, 1736044278, 931000318, 1060691710, 666879990, 1877598071, 800640759, 2139019006, 1736435710);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_xor_wide_wide()
        {
            uint3x3 a0 = uint3x3(1556324760, 207002929, 1843444873, 1632079131, 1460334334, 1607815585, 220623650, 38668553, 47193340);
            uint3x3 b0 = uint3x3(1054997548, 1523759632, 251164872, 110472397, 384031112, 1109163205, 535118981, 179106262, 1523031711);
            uint3x3 r0 = uint3x3(1646419380, 1451501345, 1662567489, 1741824470, 1105803126, 499723620, 314783655, 149092575, 1477935715);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(643663548, 1371932564, 94957188, 700973621, 370621508, 2087573076, 351476570, 1340815927, 681577472);
            uint3x3 b1 = uint3x3(1713313372, 1294118730, 520360641, 1040688781, 1020757245, 1143954843, 1281933464, 175288469, 326874157);
            uint3x3 r1 = uint3x3(1078104288, 484747486, 447544389, 399484088, 717273273, 943885263, 1486609346, 1167690402, 1004255277);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(314138777, 446857644, 1368661599, 1672499683, 1259759761, 2049102405, 1972524935, 91962333, 1960780785);
            uint3x3 b2 = uint3x3(1192052687, 1087083643, 1900865484, 1521193463, 569695524, 1622101483, 1340735463, 546583617, 1034420616);
            uint3x3 r2 = uint3x3(1437869910, 1516836311, 551090579, 958119956, 1793242549, 445489070, 981182560, 636424092, 1232544377);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(1303778459, 960040360, 822786011, 2028027011, 170382968, 32554542, 1915830925, 2001025156, 2012451132);
            uint3x3 b3 = uint3x3(262206030, 1834125935, 802756092, 611321886, 316379491, 325882121, 45335181, 1859278043, 1002624300);
            uint3x3 r3 = uint3x3(1108797141, 1416333255, 517186087, 1553020061, 419186459, 312225575, 1887600640, 429354079, 1278297104);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_xor_wide_scalar()
        {
            uint3x3 a0 = uint3x3(2124666952, 177397845, 574879617, 1937385541, 1136545648, 213863690, 535061373, 289301586, 1305234431);
            uint b0 = (493665894);
            uint3x3 r0 = uint3x3(1674536494, 402546227, 1060063719, 1846973987, 1590882582, 299103084, 42523931, 206756404, 1352725913);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(353786540, 1267729267, 125659640, 1315625690, 1730088797, 116862046, 375757978, 491079274, 191750702);
            uint b1 = (1308626970);
            uint3x3 r1 = uint3x3(1528187574, 93328233, 1232959970, 6998720, 689905479, 1224162372, 1483050112, 1397053040, 1164833332);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(187129429, 549951551, 653124416, 788984, 1479174924, 1680011736, 447453839, 890841598, 293394300);
            uint b2 = (967051293);
            uint3x3 r2 = uint3x3(847468104, 425955362, 524938077, 967311845, 1636721425, 1569126853, 588223122, 213721571, 685301601);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(527727631, 1382138962, 1206186973, 1059509471, 744733291, 64097148, 1814786305, 716239, 476052372);
            uint b3 = (529042816);
            uint3x3 r3 = uint3x3(16576911, 1307134418, 1483505245, 548297055, 871053291, 475694844, 1940126849, 528638031, 64452116);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1288453276);
            uint3x3 b0 = uint3x3(1077599928, 884741329, 212164516, 1585020328, 152985454, 1775851275, 1416249064, 1309317737, 1773918217);
            uint3x3 r0 = uint3x3(217506340, 2020616269, 1080648504, 313868596, 1171416050, 622160791, 413532788, 46573301, 628614293);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1509843030);
            uint3x3 b1 = uint3x3(1206045972, 1154916424, 1947871003, 1774252400, 1946113778, 1079717492, 290620937, 1382343363, 939045099);
            uint3x3 r1 = uint3x3(505195842, 489209886, 769935181, 809406758, 704722596, 430263842, 1219290719, 194675349, 1845940413);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1309568053);
            uint3x3 b2 = uint3x3(221134131, 885841718, 612068188, 194068085, 1396957881, 573581481, 1813817520, 86594349, 2006985393);
            uint3x3 r2 = uint3x3(1126191366, 2059580163, 1786054505, 1168069184, 491622028, 1816020124, 571655301, 1260863256, 967722628);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1431761813);
            uint3x3 b3 = uint3x3(905646837, 1522414781, 192882943, 714832744, 374210759, 215701593, 1573378082, 779254615, 711527976);
            uint3x3 r3 = uint3x3(1622008160, 266913576, 1579801450, 2144176381, 1125708626, 1502456780, 143731639, 2065991874, 2134900157);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_left_shift()
        {
            uint3x3 a0 = uint3x3(197771193, 622182602, 1283988958, 1327917304, 473415985, 432425717, 870301196, 2058433484, 1200694230);
            int b0 = (1321149625);
            uint3x3 r0 = uint3x3(1912602624, 2483027968, 3154116608, 4026531840, 1644167168, 3925868544, 402653184, 2550136832, 2885681152);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3x3 a1 = uint3x3(1531607705, 1008296534, 1447702302, 1079614371, 35667343, 1664454606, 2045594989, 2077023268, 592678686);
            int b1 = (1360008038);
            uint3x3 r1 = uint3x3(3533612608, 106468736, 2458634112, 375843008, 2282709952, 3445879680, 2069060416, 4080470272, 3571697536);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3x3 a2 = uint3x3(297755411, 1161625759, 37265945, 997793693, 1521705181, 263886278, 221147365, 2084190583, 230910816);
            int b2 = (1722762487);
            uint3x3 r2 = uint3x3(2306867200, 1333788672, 209715200, 3464495104, 1853882368, 3808428032, 1920991232, 3145728000, 2952790016);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3x3 a3 = uint3x3(71403448, 1176038816, 1382694875, 1824729613, 1535276688, 1581610518, 407677878, 1208958192, 740058147);
            int b3 = (481375728);
            uint3x3 r3 = uint3x3(2276982784, 3986685952, 1071316992, 705495040, 1989148672, 1981153280, 2880831488, 1022361600, 1680015360);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_right_shift()
        {
            uint3x3 a0 = uint3x3(548167301, 1161338299, 1617625829, 1860731847, 713958715, 196552656, 770466193, 1265099998, 572763124);
            int b0 = (1266801540);
            uint3x3 r0 = uint3x3(34260456, 72583643, 101101614, 116295740, 44622419, 12284541, 48154137, 79068749, 35797695);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3x3 a1 = uint3x3(506619530, 2031319045, 701927980, 917785020, 569504877, 185593382, 1102123711, 334005460, 1624751550);
            int b1 = (426807581);
            uint3x3 r1 = uint3x3(0, 3, 1, 1, 1, 0, 2, 0, 3);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3x3 a2 = uint3x3(280138733, 1840564178, 736389149, 1279158873, 408822762, 763607760, 348013684, 1568185874, 774126687);
            int b2 = (1598620011);
            uint3x3 r2 = uint3x3(136786, 898712, 359565, 624589, 199620, 372855, 169928, 765715, 377991);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3x3 a3 = uint3x3(1587054000, 29576474, 1880981389, 352174824, 1164508476, 425441430, 186542511, 1099859381, 1234295294);
            int b3 = (600069797);
            uint3x3 r3 = uint3x3(49595437, 924264, 58780668, 11005463, 36390889, 13295044, 5829453, 34370605, 38571727);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void uint3x3_operator_bitwise_not()
        {
            uint3x3 a0 = uint3x3(1403358969, 831360921, 2088190243, 976721016, 878283189, 308994339, 1935567517, 1420884856, 472965491);
            uint3x3 r0 = uint3x3(2891608326, 3463606374, 2206777052, 3318246279, 3416684106, 3985972956, 2359399778, 2874082439, 3822001804);
            TestUtils.AreEqual(~a0, r0);

            uint3x3 a1 = uint3x3(771711426, 2061524024, 753208488, 2097179283, 1303022493, 664744603, 1289372466, 1635981125, 1951018596);
            uint3x3 r1 = uint3x3(3523255869, 2233443271, 3541758807, 2197788012, 2991944802, 3630222692, 3005594829, 2658986170, 2343948699);
            TestUtils.AreEqual(~a1, r1);

            uint3x3 a2 = uint3x3(1545651937, 1284504687, 1342785385, 869629475, 2045854321, 1282546942, 1562433528, 1824824810, 1736570715);
            uint3x3 r2 = uint3x3(2749315358, 3010462608, 2952181910, 3425337820, 2249112974, 3012420353, 2732533767, 2470142485, 2558396580);
            TestUtils.AreEqual(~a2, r2);

            uint3x3 a3 = uint3x3(508906058, 1867418756, 388530274, 695179852, 1766938039, 897923626, 1816190464, 1362906829, 1227946838);
            uint3x3 r3 = uint3x3(3786061237, 2427548539, 3906437021, 3599787443, 2528029256, 3397043669, 2478776831, 2932060466, 3067020457);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
