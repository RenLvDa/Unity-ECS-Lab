// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble2
    {
        [TestCompiler]
        public static void double2_zero()
        {
            TestUtils.AreEqual(double2.zero.x, 0.0);
            TestUtils.AreEqual(double2.zero.y, 0.0);
        }

        [TestCompiler]
        public static void double2_constructor()
        {
            double2 a = new double2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void double2_scalar_constructor()
        {
            double2 a = new double2(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
        }

        [TestCompiler]
        public static void double2_static_constructor()
        {
            double2 a = double2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void double2_static_scalar_constructor()
        {
            double2 a = double2(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
        }

        [TestCompiler]
        public static void double2_operator_equal_wide_wide()
        {
            double2 a0 = double2(-135.18925172425304, -49.094127439471947);
            double2 b0 = double2(-220.01464591734793, 66.980020792679852);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2 a1 = double2(169.12980778940482, 240.80529772527757);
            double2 b1 = double2(499.20158576369363, -371.113114291389);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2 a2 = double2(314.73919382446411, 442.39301916695808);
            double2 b2 = double2(208.44865212610398, 390.80369133074009);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2 a3 = double2(177.92444881141398, 335.53340283759564);
            double2 b3 = double2(-72.443806920407269, 362.97643273089841);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_equal_wide_scalar()
        {
            double2 a0 = double2(65.671194345537174, 404.41550440546848);
            double b0 = (-155.8157547245807);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2 a1 = double2(-269.7301577393572, 152.99450476141385);
            double b1 = (83.630607882342588);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2 a2 = double2(-155.86829836474186, 386.36515325417986);
            double b2 = (314.67125597348024);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2 a3 = double2(290.04894007837811, -65.667489797653388);
            double b3 = (-132.63519460178691);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_equal_scalar_wide()
        {
            double a0 = (36.383921878591195);
            double2 b0 = double2(-400.48919958644046, -71.286823544319191);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (156.97811491646712);
            double2 b1 = double2(-225.23872791288363, 499.14180993435059);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-211.97992358542047);
            double2 b2 = double2(428.31192394174263, -489.50133322621758);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (-5.6915457275190988);
            double2 b3 = double2(-30.865948453017495, -362.98307221149241);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_not_equal_wide_wide()
        {
            double2 a0 = double2(279.99414576217259, -43.342018386042696);
            double2 b0 = double2(-460.912120318465, -476.00904844515446);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2 a1 = double2(-465.72473523846116, 317.46655645848557);
            double2 b1 = double2(468.13642070635058, -341.01254312182431);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2 a2 = double2(85.714987079480238, 360.89050572034466);
            double2 b2 = double2(-62.658060341448561, -458.80166718866752);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2 a3 = double2(366.08152668833804, 154.5428384070018);
            double2 b3 = double2(-457.73023316717251, -59.523265627922171);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_not_equal_wide_scalar()
        {
            double2 a0 = double2(-155.44111282911206, -19.426602134214079);
            double b0 = (-393.41354173860213);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2 a1 = double2(174.63305409934048, 59.177048472304364);
            double b1 = (507.9207296352464);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2 a2 = double2(171.15146430356026, -398.17684835855704);
            double b2 = (-58.923273352404692);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2 a3 = double2(492.20105361016522, 270.34102333259818);
            double b3 = (-165.24150879925185);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_not_equal_scalar_wide()
        {
            double a0 = (478.35313938481409);
            double2 b0 = double2(459.55319592894671, 436.45324369727314);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-488.71416806090349);
            double2 b1 = double2(392.76794475725296, -266.73665369056937);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (338.55788270503183);
            double2 b2 = double2(-338.10012475498957, -152.3145445102428);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (-452.82067868338);
            double2 b3 = double2(209.43931422449612, 50.107968592135194);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_wide_wide()
        {
            double2 a0 = double2(51.710243010758518, -313.85556450200062);
            double2 b0 = double2(-261.83523881707117, -19.810742149041403);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double2 a1 = double2(283.04767359562572, 235.02188621974642);
            double2 b1 = double2(-149.25882084167506, 205.99822316225539);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double2 a2 = double2(44.0783565249659, -207.25566659088042);
            double2 b2 = double2(-306.02438535635565, 102.12168006884008);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double2 a3 = double2(3.3829410091894943, -144.30134326978651);
            double2 b3 = double2(231.90633760760829, 179.49885305180158);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_wide_scalar()
        {
            double2 a0 = double2(-221.86977325280651, -121.54646807608498);
            double b0 = (199.06751808853244);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double2 a1 = double2(-97.52392511140738, 67.118990214131259);
            double b1 = (479.88107775146193);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double2 a2 = double2(137.32880574899207, 258.27909362422258);
            double b2 = (282.96659601990439);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double2 a3 = double2(-111.41316061439608, 82.665427008022334);
            double b3 = (-288.08113278452356);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_scalar_wide()
        {
            double a0 = (-250.4849370692321);
            double2 b0 = double2(-377.19654887597846, -505.14754104295167);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (375.92672198634909);
            double2 b1 = double2(110.17393474940855, -118.09757452742082);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (-40.45089079833167);
            double2 b2 = double2(-299.74430932651478, 31.437125935888389);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (-458.904539560389);
            double2 b3 = double2(13.684679276163024, -458.50690839183841);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_wide_wide()
        {
            double2 a0 = double2(-229.29066501804192, 505.536608216137);
            double2 b0 = double2(-445.84502407808088, -420.03529210576568);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double2 a1 = double2(-73.80706862071861, 100.29203777215071);
            double2 b1 = double2(299.02440108872224, -13.880978829171966);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double2 a2 = double2(-419.21478124112582, -159.55974753180504);
            double2 b2 = double2(151.56173593903043, -163.5094302461992);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double2 a3 = double2(-396.7703608929973, 127.03739482119556);
            double2 b3 = double2(-391.09603733154762, 479.2837710228207);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_wide_scalar()
        {
            double2 a0 = double2(11.156317000815761, -411.02322382993214);
            double b0 = (-302.81693877969724);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double2 a1 = double2(385.88556188432756, -491.18003033622171);
            double b1 = (-485.10304831206008);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double2 a2 = double2(405.17534632476759, 69.269281181166548);
            double b2 = (173.57509740329124);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double2 a3 = double2(501.30683183172107, -86.124509613087639);
            double b3 = (-367.027771405423);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_scalar_wide()
        {
            double a0 = (453.54610201974685);
            double2 b0 = double2(-226.20441423459187, -423.46500487973213);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (409.40550227156166);
            double2 b1 = double2(453.87706277048073, 87.475727837288673);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (113.79560308987072);
            double2 b2 = double2(176.40926154721956, -140.44002944810319);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (-182.48286804113673);
            double2 b3 = double2(-158.29329188088576, -162.68531830733889);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_equal_wide_wide()
        {
            double2 a0 = double2(240.09053169940159, 462.2131528622532);
            double2 b0 = double2(-81.203838624620744, 493.63743876555816);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2 a1 = double2(293.08251561461134, -427.87067361728782);
            double2 b1 = double2(-411.47211451617636, 99.164449499530974);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2 a2 = double2(-405.5227226715175, 204.59190211286386);
            double2 b2 = double2(-295.66769875943089, -480.46254824123463);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2 a3 = double2(294.670105832941, -327.56444445604666);
            double2 b3 = double2(74.414040361723892, 260.916124226952);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_equal_wide_scalar()
        {
            double2 a0 = double2(309.1924356469849, 69.673792633076118);
            double b0 = (292.92427148154206);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2 a1 = double2(-101.72418622939114, -346.01106731314724);
            double b1 = (-315.97240629604664);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2 a2 = double2(424.15386577330241, -483.90265320423185);
            double b2 = (-410.87006945669191);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2 a3 = double2(183.82114538169515, -257.87003791419329);
            double b3 = (320.44249287268258);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_less_equal_scalar_wide()
        {
            double a0 = (-511.15238141974078);
            double2 b0 = double2(51.159012579898786, 340.44369022010062);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (312.81429519914752);
            double2 b1 = double2(354.19252626699983, 136.39671165142056);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (-94.767871185563422);
            double2 b2 = double2(288.544332877055, 304.04282369466625);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (-148.61806089646092);
            double2 b3 = double2(-506.30010127755816, 27.581254256694251);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_equal_wide_wide()
        {
            double2 a0 = double2(-386.59181302906563, -157.12078221008215);
            double2 b0 = double2(153.44301350109424, 49.892483019219981);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2 a1 = double2(391.01526445477054, -511.88687133783793);
            double2 b1 = double2(78.025787628267835, 138.81373292711271);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2 a2 = double2(-5.4220387960886569, 287.64527501149348);
            double2 b2 = double2(-225.51057802211056, -339.35611335344436);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2 a3 = double2(-122.53520184500849, 7.4814426933794493);
            double2 b3 = double2(-373.302078182484, 364.9358934671319);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_equal_wide_scalar()
        {
            double2 a0 = double2(495.457423679278, -14.345115906719627);
            double b0 = (189.20512804258851);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2 a1 = double2(-463.47478053694346, -246.86571776441565);
            double b1 = (217.51749215718246);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2 a2 = double2(-377.65869706573835, -123.33294373533357);
            double b2 = (53.815095211293169);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2 a3 = double2(-221.50546441856096, -116.44038277326172);
            double b3 = (252.99433410027734);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_greater_equal_scalar_wide()
        {
            double a0 = (215.43534169692327);
            double2 b0 = double2(204.80295310020585, -101.10404853760451);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-122.05503827056617);
            double2 b1 = double2(-70.456147941973143, -239.62025677395064);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (-185.99272426683115);
            double2 b2 = double2(-455.61258027312, 276.66581476697036);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (79.39918831707871);
            double2 b3 = double2(416.42054791768112, 379.27350801009379);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_add_wide_wide()
        {
            double2 a0 = double2(465.14837644302679, 278.91072548502621);
            double2 b0 = double2(483.99436186440028, -204.07667193379098);
            double2 r0 = double2(949.14273830742707, 74.834053551235229);
            TestUtils.AreEqual(a0 + b0, r0);

            double2 a1 = double2(-277.52992237616792, -65.197214395365336);
            double2 b1 = double2(-365.67356007437854, -509.92086076639634);
            double2 r1 = double2(-643.20348245054652, -575.11807516176168);
            TestUtils.AreEqual(a1 + b1, r1);

            double2 a2 = double2(-473.32437561141529, -4.6955420992782138);
            double2 b2 = double2(-270.69751108377125, 486.76397846954126);
            double2 r2 = double2(-744.02188669518659, 482.06843637026304);
            TestUtils.AreEqual(a2 + b2, r2);

            double2 a3 = double2(-470.53676698661258, -109.95011453980118);
            double2 b3 = double2(267.49177587567442, 251.6425212601398);
            double2 r3 = double2(-203.04499111093816, 141.69240672033862);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_add_wide_scalar()
        {
            double2 a0 = double2(459.89829728561369, -447.66336104258119);
            double b0 = (500.99725913489112);
            double2 r0 = double2(960.89555642050482, 53.333898092309937);
            TestUtils.AreEqual(a0 + b0, r0);

            double2 a1 = double2(-94.438627525436971, -36.254356162741033);
            double b1 = (126.42986279652916);
            double2 r1 = double2(31.991235271092194, 90.175506633788132);
            TestUtils.AreEqual(a1 + b1, r1);

            double2 a2 = double2(-349.64130060264904, -478.41478489265535);
            double b2 = (-2.7912590516690443);
            double2 r2 = double2(-352.43255965431808, -481.20604394432439);
            TestUtils.AreEqual(a2 + b2, r2);

            double2 a3 = double2(443.11525246273504, 41.32102133767728);
            double b3 = (268.092225914864);
            double2 r3 = double2(711.207478377599, 309.41324725254128);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_add_scalar_wide()
        {
            double a0 = (-325.51276484388518);
            double2 b0 = double2(-264.08813178915909, -106.00925998855814);
            double2 r0 = double2(-589.60089663304427, -431.52202483244332);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (-355.44729320865463);
            double2 b1 = double2(-447.33029362528134, -158.70021040677102);
            double2 r1 = double2(-802.777586833936, -514.14750361542565);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (-199.48369154682553);
            double2 b2 = double2(180.31809123806568, 337.57936898692481);
            double2 r2 = double2(-19.165600308759849, 138.09567744009928);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (-37.05501486596421);
            double2 b3 = double2(230.80498014707348, -140.17433339924287);
            double2 r3 = double2(193.74996528110927, -177.22934826520708);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_sub_wide_wide()
        {
            double2 a0 = double2(133.37101680290471, -131.8321183341705);
            double2 b0 = double2(123.46028739002543, 359.56010048443454);
            double2 r0 = double2(9.9107294128792773, -491.39221881860504);
            TestUtils.AreEqual(a0 - b0, r0);

            double2 a1 = double2(-197.29314407952739, -485.286571013409);
            double2 b1 = double2(-48.24847819667707, 478.97904680621764);
            double2 r1 = double2(-149.04466588285032, -964.26561781962664);
            TestUtils.AreEqual(a1 - b1, r1);

            double2 a2 = double2(-337.55033103448818, 471.66710470228782);
            double2 b2 = double2(207.15832886805686, 142.36730462981723);
            double2 r2 = double2(-544.708659902545, 329.29980007247059);
            TestUtils.AreEqual(a2 - b2, r2);

            double2 a3 = double2(146.5066197600712, -130.58504372955537);
            double2 b3 = double2(-125.60551005490379, -65.299004823574307);
            double2 r3 = double2(272.112129814975, -65.286038905981059);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_sub_wide_scalar()
        {
            double2 a0 = double2(48.936717294592768, 410.45158953706346);
            double b0 = (-291.59041442144212);
            double2 r0 = double2(340.52713171603489, 702.04200395850557);
            TestUtils.AreEqual(a0 - b0, r0);

            double2 a1 = double2(-364.44171612544062, -460.06732318367222);
            double b1 = (163.98060353285666);
            double2 r1 = double2(-528.42231965829728, -624.04792671652888);
            TestUtils.AreEqual(a1 - b1, r1);

            double2 a2 = double2(110.91942339340198, 180.26971420099483);
            double b2 = (204.35834441164434);
            double2 r2 = double2(-93.438921018242354, -24.088630210649512);
            TestUtils.AreEqual(a2 - b2, r2);

            double2 a3 = double2(-377.92569344952972, 400.53491968686455);
            double b3 = (-470.26204297983185);
            double2 r3 = double2(92.33634953030213, 870.79696266669634);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_sub_scalar_wide()
        {
            double a0 = (294.58645905861);
            double2 b0 = double2(452.35251757705237, 256.98980891750648);
            double2 r0 = double2(-157.76605851844238, 37.59665014110351);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (-275.159888634067);
            double2 b1 = double2(-89.027518075437968, 488.22838829840919);
            double2 r1 = double2(-186.13237055862902, -763.38827693247617);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (-333.21728030462623);
            double2 b2 = double2(-64.232989102710519, -66.041730196234653);
            double2 r2 = double2(-268.98429120191571, -267.17555010839158);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (341.20492831859963);
            double2 b3 = double2(-385.775056303374, 75.394746577085357);
            double2 r3 = double2(726.9799846219737, 265.81018174151427);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mul_wide_wide()
        {
            double2 a0 = double2(-394.78053898121254, -412.37219519744264);
            double2 b0 = double2(-149.76397831261346, -345.04538671348496);
            double2 r0 = double2(59123.904078224172, 142287.1235617903);
            TestUtils.AreEqual(a0 * b0, r0);

            double2 a1 = double2(-25.874570143350638, -241.04595886964626);
            double2 b1 = double2(-284.33404721148963, 267.97923648915219);
            double2 r1 = double2(7357.0212487164608, -64595.312016683383);
            TestUtils.AreEqual(a1 * b1, r1);

            double2 a2 = double2(-93.675987525692221, 244.15999257013198);
            double2 b2 = double2(-326.64849558782225, -150.68967754705329);
            double2 r2 = double2(30599.120397970968, -36792.390550284115);
            TestUtils.AreEqual(a2 * b2, r2);

            double2 a3 = double2(494.68846606402121, 53.537962700025105);
            double2 b3 = double2(207.73243794577775, 366.19289248352538);
            double2 r3 = double2(102762.84107913627, 19605.221418797286);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mul_wide_scalar()
        {
            double2 a0 = double2(328.20302191758674, -290.10672272839895);
            double b0 = (192.21119055161773);
            double2 r0 = double2(63084.293585418032, -55761.758562653624);
            TestUtils.AreEqual(a0 * b0, r0);

            double2 a1 = double2(236.99572454998065, 357.90315811610924);
            double b1 = (120.48136692889102);
            double2 r1 = double2(28553.568850084604, 43120.661717995856);
            TestUtils.AreEqual(a1 * b1, r1);

            double2 a2 = double2(134.86723214707672, -438.272912467957);
            double b2 = (-477.31047104173825);
            double2 r2 = double2(-64373.542104216656, 209192.25029491508);
            TestUtils.AreEqual(a2 * b2, r2);

            double2 a3 = double2(-46.729179165665585, 422.08249374017237);
            double b3 = (-238.40500103608008);
            double2 r3 = double2(11140.470007405675, -100626.57735743705);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mul_scalar_wide()
        {
            double a0 = (-464.534700371574);
            double2 b0 = double2(329.36093846399376, -198.68342671109525);
            double2 r0 = double2(-152999.58486347177, 92295.346096036214);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (184.07942518223047);
            double2 b1 = double2(256.01618754864489, 266.22629297255833);
            double2 r1 = double2(47127.312641300661, 49006.78297878462);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (-97.894749448585685);
            double2 b2 = double2(159.74810583877752, -351.82222263506719);
            double2 r2 = double2(-15638.500795973274, 34441.548335304433);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (491.80157660497423);
            double2 b3 = double2(49.902031206480274, 424.46256871915546);
            double2 r3 = double2(24541.897623137622, 208751.36050587788);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_div_wide_wide()
        {
            double2 a0 = double2(246.26574933075619, -269.85612953354428);
            double2 b0 = double2(172.11981423763552, -77.141104972521362);
            double2 r0 = double2(1.4307809383918566, 3.4982144685336105);
            TestUtils.AreEqual(a0 / b0, r0);

            double2 a1 = double2(-451.61952588130697, -7.38850236283082);
            double2 b1 = double2(-325.8353723612779, -450.60868117334724);
            double2 r1 = double2(1.3860359070548143, 0.016396715535066435);
            TestUtils.AreEqual(a1 / b1, r1);

            double2 a2 = double2(-308.20558681534862, -373.394808704683);
            double2 b2 = double2(-261.26215398556656, -122.44949847201326);
            double2 r2 = double2(1.1796794220427942, 3.0493780159501847);
            TestUtils.AreEqual(a2 / b2, r2);

            double2 a3 = double2(360.41863482092447, 25.80972458133931);
            double2 b3 = double2(-93.210781379235357, -442.00522705633438);
            double2 r3 = double2(-3.8667054335113131, -0.05839235149599218);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_div_wide_scalar()
        {
            double2 a0 = double2(-244.51745116175965, 69.112274917360537);
            double b0 = (-60.024377612408443);
            double2 r0 = double2(4.0736357608014941, -1.1514034408425655);
            TestUtils.AreEqual(a0 / b0, r0);

            double2 a1 = double2(-333.02311888943575, 403.24561257066466);
            double b1 = (257.39682519500923);
            double2 r1 = double2(-1.2938120687274619, 1.5666300944666172);
            TestUtils.AreEqual(a1 / b1, r1);

            double2 a2 = double2(154.34436066185322, -261.88639200007844);
            double b2 = (131.52659160062979);
            double2 r2 = double2(1.1734840748440269, -1.9911288570092047);
            TestUtils.AreEqual(a2 / b2, r2);

            double2 a3 = double2(-348.92380516087815, 210.55792174607416);
            double b3 = (-275.53868187383688);
            double2 r3 = double2(1.26633328862567, -0.76416828415577609);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_div_scalar_wide()
        {
            double a0 = (41.737658758525527);
            double2 b0 = double2(-422.676129776368, 248.12963235011773);
            double2 r0 = double2(-0.098746193168297289, 0.1682090863683405);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (449.39137741988122);
            double2 b1 = double2(245.85813796047967, -326.62061253498337);
            double2 r1 = double2(1.8278482914896166, -1.3758818646871169);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (163.71510489457989);
            double2 b2 = double2(333.664472020075, 38.291076916405473);
            double2 r2 = double2(0.4906578872584611, 4.2755419298337261);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-472.97976062864984);
            double2 b3 = double2(192.23013958345643, -200.29686960964318);
            double2 r3 = double2(-2.4604870061143891, 2.3613936730535827);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mod_wide_wide()
        {
            double2 a0 = double2(-442.30985924336585, 368.50046246522129);
            double2 b0 = double2(-43.245045443645211, -144.19587690392319);
            double2 r0 = double2(-9.8594048069137443, 80.1087086573749);
            TestUtils.AreEqual(a0 % b0, r0);

            double2 a1 = double2(-1.0938966279355213, -364.67383473211612);
            double2 b1 = double2(-62.640481739603217, -336.82826510855381);
            double2 r1 = double2(-1.0938966279355213, -27.845569623562312);
            TestUtils.AreEqual(a1 % b1, r1);

            double2 a2 = double2(-197.34394487987458, -34.034902350062);
            double2 b2 = double2(-154.6102545981343, -154.02935583611452);
            double2 r2 = double2(-42.73369028174028, -34.034902350062);
            TestUtils.AreEqual(a2 % b2, r2);

            double2 a3 = double2(-101.34858350704826, 208.31857142612273);
            double2 b3 = double2(487.0462093237071, -469.82909105244516);
            double2 r3 = double2(-101.34858350704826, 208.31857142612273);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mod_wide_scalar()
        {
            double2 a0 = double2(-433.41699548876704, -5.5141427542614565);
            double b0 = (-90.499235433758827);
            double2 r0 = double2(-71.420053753731736, -5.5141427542614565);
            TestUtils.AreEqual(a0 % b0, r0);

            double2 a1 = double2(393.39439958771425, -120.80601626299602);
            double b1 = (299.41153277988155);
            double2 r1 = double2(93.982866807832693, -120.80601626299602);
            TestUtils.AreEqual(a1 % b1, r1);

            double2 a2 = double2(-502.939041133476, 186.09479698263794);
            double b2 = (-450.80766245853511);
            double2 r2 = double2(-52.131378674940891, 186.09479698263794);
            TestUtils.AreEqual(a2 % b2, r2);

            double2 a3 = double2(-84.473635951277629, 433.45469041981482);
            double b3 = (-318.78148356023314);
            double2 r3 = double2(-84.473635951277629, 114.67320685958168);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_mod_scalar_wide()
        {
            double a0 = (-396.4224028049141);
            double2 b0 = double2(-159.14024384279747, 230.17333399046834);
            double2 r0 = double2(-78.141915119319151, -166.24906881444576);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (14.779358632294134);
            double2 b1 = double2(-303.15649738123477, 399.63502020371845);
            double2 r1 = double2(14.779358632294134, 14.779358632294134);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (206.69470534412881);
            double2 b2 = double2(397.04482263934096, -393.89064735634747);
            double2 r2 = double2(206.69470534412881, 206.69470534412881);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (-372.06709426085797);
            double2 b3 = double2(201.01229796233224, -95.5668547598491);
            double2 r3 = double2(-171.05479629852573, -85.366529981310691);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2_operator_plus()
        {
            double2 a0 = double2(271.6708086802023, -79.080240524876956);
            double2 r0 = double2(271.6708086802023, -79.080240524876956);
            TestUtils.AreEqual(+a0, r0);

            double2 a1 = double2(-330.98506203805334, 315.44952860262686);
            double2 r1 = double2(-330.98506203805334, 315.44952860262686);
            TestUtils.AreEqual(+a1, r1);

            double2 a2 = double2(319.22218742930431, -350.30858270745193);
            double2 r2 = double2(319.22218742930431, -350.30858270745193);
            TestUtils.AreEqual(+a2, r2);

            double2 a3 = double2(-320.51845875406565, -107.00351267075331);
            double2 r3 = double2(-320.51845875406565, -107.00351267075331);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void double2_operator_neg()
        {
            double2 a0 = double2(420.22718854445372, -196.25749811728366);
            double2 r0 = double2(-420.22718854445372, 196.25749811728366);
            TestUtils.AreEqual(-a0, r0);

            double2 a1 = double2(-335.42683068636188, -33.014395013923945);
            double2 r1 = double2(335.42683068636188, 33.014395013923945);
            TestUtils.AreEqual(-a1, r1);

            double2 a2 = double2(-498.57532071442125, -270.85946787095605);
            double2 r2 = double2(498.57532071442125, 270.85946787095605);
            TestUtils.AreEqual(-a2, r2);

            double2 a3 = double2(19.686896571743773, -180.60051473444349);
            double2 r3 = double2(-19.686896571743773, 180.60051473444349);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void double2_operator_prefix_inc()
        {
            double2 a0 = double2(-99.79557113526181, 458.74185082816609);
            double2 r0 = double2(-98.79557113526181, 459.74185082816609);
            TestUtils.AreEqual(++a0, r0);

            double2 a1 = double2(96.179026886904126, -315.728967098393);
            double2 r1 = double2(97.179026886904126, -314.728967098393);
            TestUtils.AreEqual(++a1, r1);

            double2 a2 = double2(-299.23014583216525, -456.89028832730384);
            double2 r2 = double2(-298.23014583216525, -455.89028832730384);
            TestUtils.AreEqual(++a2, r2);

            double2 a3 = double2(-76.507656371457358, 64.0964734852763);
            double2 r3 = double2(-75.507656371457358, 65.0964734852763);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void double2_operator_postfix_inc()
        {
            double2 a0 = double2(322.94356623429042, 472.05246542024076);
            double2 r0 = double2(322.94356623429042, 472.05246542024076);
            TestUtils.AreEqual(a0++, r0);

            double2 a1 = double2(203.48761925636211, -31.420532002775246);
            double2 r1 = double2(203.48761925636211, -31.420532002775246);
            TestUtils.AreEqual(a1++, r1);

            double2 a2 = double2(455.33662459595905, 55.736877228942149);
            double2 r2 = double2(455.33662459595905, 55.736877228942149);
            TestUtils.AreEqual(a2++, r2);

            double2 a3 = double2(153.75031645305, -427.40105100506969);
            double2 r3 = double2(153.75031645305, -427.40105100506969);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void double2_operator_prefix_dec()
        {
            double2 a0 = double2(-416.20121712992022, -96.637880131899351);
            double2 r0 = double2(-417.20121712992022, -97.637880131899351);
            TestUtils.AreEqual(--a0, r0);

            double2 a1 = double2(-50.145671629414721, 439.47906156977592);
            double2 r1 = double2(-51.145671629414721, 438.47906156977592);
            TestUtils.AreEqual(--a1, r1);

            double2 a2 = double2(-304.40081920493435, 246.08898293510492);
            double2 r2 = double2(-305.40081920493435, 245.08898293510492);
            TestUtils.AreEqual(--a2, r2);

            double2 a3 = double2(171.96452935597142, 298.28480710568135);
            double2 r3 = double2(170.96452935597142, 297.28480710568135);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void double2_operator_postfix_dec()
        {
            double2 a0 = double2(-376.59242719066907, 16.969734438215255);
            double2 r0 = double2(-376.59242719066907, 16.969734438215255);
            TestUtils.AreEqual(a0--, r0);

            double2 a1 = double2(-0.25066399585949739, 409.55752940175944);
            double2 r1 = double2(-0.25066399585949739, 409.55752940175944);
            TestUtils.AreEqual(a1--, r1);

            double2 a2 = double2(47.856652520530247, -262.062590959511);
            double2 r2 = double2(47.856652520530247, -262.062590959511);
            TestUtils.AreEqual(a2--, r2);

            double2 a3 = double2(-182.40572866350681, -129.23265582380475);
            double2 r3 = double2(-182.40572866350681, -129.23265582380475);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void double2_shuffle_result_1()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public static void double2_shuffle_result_2()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), double2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), double2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), double2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), double2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), double2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), double2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), double2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), double2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), double2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), double2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), double2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), double2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), double2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), double2(3, 3));
        }

        [TestCompiler]
        public static void double2_shuffle_result_3()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), double3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), double3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), double3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), double3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), double3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), double3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), double3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), double3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(3, 1, 1));
        }

        [TestCompiler]
        public static void double2_shuffle_result_4()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), double4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), double4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), double4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), double4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), double4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), double4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), double4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), double4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), double4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), double4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double4(2, 0, 0, 0));
        }


    }
}
