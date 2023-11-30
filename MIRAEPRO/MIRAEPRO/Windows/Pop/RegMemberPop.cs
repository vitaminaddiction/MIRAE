﻿using Lib.Frame;
using MIRAEPRO.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MIRAEPRO.Windows.Pop
{
    public partial class RegMemberPop : MasterPop
    {
        public RegMemberPop()
        {
            InitializeComponent();            
        }
        public override void Initialize(ePopMode popMode, object aParam)
        {
            base.Initialize(popMode, aParam);
            SetLayOut(aParam);
            Display();
        }
        private void SetLayOut(object aParam)
        {
            if (m_PopMode == ePopMode.Add)
            {
                SetLayout4Add();
            }
            else if (m_PopMode == ePopMode.Modify)
            {
                SetLayout4Read();
            }
            else if (m_PopMode == ePopMode.Add2)
            {
                SetLayout4Add2();
            }
        }
        private void SetLayout4Add() 
        {
            this.Text = "회원가입 및 입학상담 신청";
        }
        private void SetLayout4Read()
        {
            this.Text = "개인정보 수정";
            btn_register.Text = "수정완료";
        }
        private void SetLayout4Add2()
        {
            this.Text = "학생추가";
            btn_register.Text = "추가완료";
        }
        private void Display()
        {
            if (m_PopMode == ePopMode.Add)
            {
                Display4Add();
            }
            else if (m_PopMode == ePopMode.Modify)
            {
                Display4Modify();
            }
            else if (m_PopMode == ePopMode.Add2)
            {
                Display4Add2();
            }
        }
        private void Display4Add()
        {
            tbox_Pcontact.Text = "";
            tbox_Pemail.Text = "";
            tbox_Pid.Text = "";
            tbox_Pname.Text = "";
            tbox_Ppwd.Text = "";
            tbox_Saddr.Text = "";
            tbox_Scontact.Text = "";
            tbox_Sid.Text = "";
            tbox_Sname.Text = "";
            tbox_Spwd.Text = "";
            tbox_score.Text = "";
            dtp_reg.Value = DateTime.Now;
            rbtn_male.Checked = true;
            pbox_Spicture.Image = Properties.Resources._default;
        }
        private void Display4Modify()
        {
            DataRow dr = App.Instance().DBManager.ReadInfo(App.Instance().parent_id, App.Instance().student_id);
            tbox_Pid.Text = App.Instance().parent_id;
            tbox_Pname.Text = Convert.ToString(dr["Pname"]);
            tbox_Pcontact.Text = Convert.ToString(dr["Pcontact"]);
            tbox_Pemail.Text = Convert.ToString(dr["Pemail"]);
            tbox_Sid.Text = App.Instance().student_id;
            tbox_Sname.Text = Convert.ToString(dr["Sname"]);
            if (Convert.ToString(dr["Sgender"]) == "W")
            {
                rbtn_female.Checked = true;
            }
            else
            {
                rbtn_male.Checked = true;
            }
            tbox_Scontact.Text = Convert.ToString(dr["Scontact"]);
            tbox_Saddr.Text = Convert.ToString(dr["Saddr"]);
            dtp_reg.Value = Convert.ToDateTime(dr["date_register"]);
            string picture = "";
            if (dr["picture"] != DBNull.Value)
            {
                picture = Convert.ToString(dr["picture"]);
            }
            if(picture.Length == 0)
            {
                picture = "89504E470D0A1A0A0000000D4948445200000080000000AF080600000035C4D628000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA86400001A3F49444154785EEDDD8792E3C8B185E1FBFE4FB6B22B2FADBC5DD995F7AE6F7C1DF14FE442ECE91E1220D1439C888C0281B299A7B2B20AE899FF7B3870D7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E7380870E73808B0C07FFFFBDF4FA5EF3BEE9200A78CEBDEBD187DE22E08308DFB9FFFFCE7E19FFFFCE7C3BFFFFDEF873FFDE94F0F3FF9C94F1E3EFAE8A34771ED9E3CE5AF6CBFDF37DC1501C83FFEF18F871FFEF0870F5FFCE2171FBEF0852FBC91CF7FFEF30F9FFBDCE71EE54B5FFAD2C3F7BFFFFDC7BCEFABE1C37B458069ACAE67FAEB5FFFFAE12B5FF9CAA78C3D8DEF7ADE4384DFFCE6378F654FD5F73EE0D51020852FDDF34C615ECB5BFA8B5FFCE2CDAC67DC8CEEDE97BFFCE54762B8EE7E79DC5356BDB3BE998653FDD93B5E05019606A678F2AF7FFDEBE1AF7FFDEBC31FFFF8C747F9F39FFFFCB8BEF7BC729E4DC31306FFF8E38F1FFEF297BF3CBA7AE2DABDAF7EF5AB9F22C1871F7EF8F0DBDFFEF6B12E7556AF542C416A4F1ACAB767BCCA2580917FF6B39F3DCEDC0C9581CDD81FFCE0078FC6CC405CB9E79EC9FFBDEF7DEFB10ECFA7D1BA26DFFEF6B71FCB4C2F517DE477BFFBDD632CF1CD6F7EF3E1EB5FFFFAC3B7BEF5AD871FFFF8C78F64F3BCFAF68E5743800C634D5E1A7DCED6F99B417EFEF39F3F7CF6B39F7D73EF3BDFF9CE9BFA9E3250CF90A0FA7801757DF2C927FF433CF5D717C283B49B0075ED950CBB26404A939A553FFDE94FDF283D654F12B896669CA4992FE51920E32C310DF5F7BFFFFDD17B3070F590DA2CADFEFAE01EC2881D60AFC687DD7B00CA6BE64F6313C6F9D18F7EF418DDFFFEF7BF7F2408772C4F0622E5B7B5ABBEA78CD2FDF2584EAA4F1DD24902B184192FED79228F7EC36CEFA9B66F8157E101ACD7ADE329D73A6E8696A75460F8CB5FFEF27106969761188DFB96EF3903CCE70C583DDA6FB66B5FD01951B46BFD170B9497E8C73C4F78AEED6B63F7042022F30C99F20BB4409EE9D25DF30A192B8330103C6784F99C67A99E6209FDD17EFD838880AC3C4DFD55462C1266993D60F74B00C58AB4E7AC2A827F0A9E31D077BFFBDD37E5A47FF8C31F5EA4FC9947B4AF2C319BBFF18D6F3CCEF620EF52CC7881A2761140B959664FD8BD07A04C33302338B3EFD953C810667CE5D4616968A6BEAD3CF45CE49F1721EAACFCA93ABACF4B28C7F852CBC51EB17B0F206A3793289130E273C808628466BFD4FAECFE5C2E4EA1F24499DA472233F9B9F2C0DB28D30EC252B247ECDE032000456684CEE65F82490065A511E82923AABB6782C659DEF572ED3F05CF2240E52D252FEDF735B15B0264044B40C6970AB096C63BA558F71CC6CCE583589BDDF77C965BD6C180ADE3CAD5874E186159A63AF5EF57BFFAD5A7CAD6E6DEF02A82C0AF7DED6B6F0C584095B21398BF95735C5CE43E8D68CF6E6DAF9E0825250E70E4A94DE5C8673EF39947024E2F9040D7EA152C561E09F7BA15DC2D01A6926CA3F2000CCAB0190D66DEAE056BCD7EE5A4EA702F422093BA2D0B8CEE50C9ACAFCC2CE75A59A9F5BCF6974695EADF2C673712665FF7805D12602AC935774AA12423F48A7609F718DFE95C6590669E12665833DA358914056D52F795692750397D70CE90C7A85D9E81F1CB571D9693F2CC740FD8B5072002B96625C59BB5AE29D696D09A9C4B96D72C2E8FFC52EE9C5BE6861DED327CDBB3EACA587E930F3EF8E031AF3307F56B2B72C8479C4E3A94F256D0D2507BB33E69EDEBE324CD1EB0EB2090C23ACCA1C8667F464AC90CE119C9481982A1FFF6B7BF7D4AF9488328198C4406F919D47706114B1944E898B73694A9DCAC23C3CF3CDA531751EF5EB0EB20B0489A023334E3B84ED13D5B1A9F081E1932C543062D450E87348407C9E8E59F79CDE2BE27AC8DFAE05EFDD24F1F9822937BDDF751C9AC7B0FD86D0C40D9CB376CF6D20C21F5AE3EA5CB131108C33B89336BE5AFCED0F5329D706F0A44066B3A2268471FF5C332255E106B44BA6297FA26FF73C7D8D7C66E3D00974979CD1E6B6D8A933206574EC9F23208A3330E2597EF540AF31A96BFC32CBB2C4F78109E437CC17B4492C47B8CC620F6B0EB707F2FD805015248B39501E7CCE74A29782A778F58F64D7FF5BB2503118A49661C70CBF1ECC603A43C8A31A39B35C4D66AE6B9A5C25E8AD9479E69C60D76148DF5D6D8950790767E5F40676D6DDD4CF68ED947D70C2D3E28164086DE0EDE7A3CBBF30082284ACA03CC039F5B2BEB5DD07892F9491B71549C07B8E5B87615049AFDB65014C40388B0DDDB02293D036D0D6D307A24C80BDCD2F8B09B258038726DF68B98AD9D6B2AA8BA966958B3AD53F07AB9E016C1C502B78E0376E30144CCF6C97386CC37685B421B4FB5B356FBEA31C6BC0022105BD95B623704704A96F129C641CF16B3236367D8CEE89F4286D39765D9774165F202C4789D5F9C5BE71AB839011AB8337FB3BEE8DF691AACA9188604FB702F7A28FFA9D3C2E0B9635D07519DF09D0B65116E7A3A69EF2A6E815D7800B34BF0675620802D13856CA114CBCA0CC67A4903CB14183EAFE41533B2BC6BBF66BDC4AB64751AAB7AC53E3D9B792796BFD7C24D09D0A07C90C120B9C519FCAD397075692B834A2D357980D06FEBB3FE4416E932EFBB40FB84579975DAED980473C99BE3EF7A0BEC6209E8BB7FE2A89482B680B6183CA259729C3B4C650786E6FAE5939F9CEB019650BE771D91C03B8DDE2778BE6CE7D2369FC2CD08D080189BD153449F6EC3DA83A6E0CE19F200A74EE45C134B45F9F4CD9174CFCEC12C6BDDAFDED91FBAB03D4488E5ABEC2D701502348839182996E7FE5384F5716DD466A77109A50BCAA03CE01E62F210FA4410A76DE9CC7B2E8C5D30388D3FF5D07DC1EA6C778DB6273627401DCEA571718C8CE5146C9019C3B9BFC1AE8DFA30FFD25700365F314FE8ABED5A7909F7BF361C73AB3BC393764211815E780579A138612D225CCD03B4F5CA052FC5C07B4BB626D44718B51732DAA360DF0EF42C94DFB674E69DBB85B5E0985B9C210EB113F0AD802590C1E7C4880CF2EAEBECEFA5D88C0029923BB5763270039903EBDAFD5EFCACA9E8EAE2D245DBB547C9FA4699B3BDDA9F5F152BD3DF04AE85EACA98B54B784131404BC4D4593BA4CA5F8A4D085007CD7AFF240B9736D753836100D13FAF80FD9605F92BBF16AAAB00B06567FE9DE06CAF19862CF5972196F92E85BA4ED5573B8487A01FFA4A87F4E6EF12D6EACBEA04A8F3665C9F435138716D66F1089D7E3D259762D6519D3C0C1288EE9FFA40B37B620024109720E8B530FB840CBC541FC81084A4D77966700936F1003A2EC09A86C75E862FEA86A9FC39F035B16C23BCA4AD659F5E52662DD4165D9296A44E0F11D8FD4BB13A0174CAD66EE9F2FBEB98704D654E4569B7C39625A6D243F7A4A7CA6C8DDAB51CD025E34B2DAD6BF4671302CCB3762977DA40D6E8F4BB407F18DC198028BB13B769E489FA47E1882C42D77F9EEBDAFDAF2DA9FE5A8E108017985BE64BFAB42A017464F94799A7CEDAAF017D218C67DDA7307DE14AF5AFD7B0A07FF511593C93470C606BAA2C411E65E4AD6CE9D6D08E18A62555BAC6BF39B03A01FC8D5C9D44027F177F0D2C15E13705E987202E23BB2F8A6650C155F708E39BF122ED94EBB9FBBC817121947BD786BE381A4EAFFAE25CE052AC4E008A6DF63B7899EB6DE9169875BBE6B2FB4B1DBF2340E21D0057CAD5778F82CD7C6F01FDAE1C48EDC1799096836BA2314DEF3AFFECFC5CAC4E804EFA3074E9FEAFA534ED303065D98E664C320D8B208CCAE0B6A56679AF66CB4FFAAD2E63EBBCE29AA8CFF37CA293D3E41CAC1E04C65032D7D96B429BB9F969F09E251D52E96BC7AFEEC95BB9041041BE5B7DD3AF4FF338DB79C0A5D894005B9C9FBF04DA34ABF5858B9F469452246372E776075CABD9EDDA0C8348D035C843F91D62DD02FACCFDEB070F50DFCEEDCFEA0430432240FFA0D354FE35A01D06A6A0DEF82DDBEED5F0DC4A218B254C0008F59DB84668B3EE52A59F0BED1563E5ADBA7F6E5F5627800EC6D0A9AC5BC096545F188E71CD7406B72BD04F6BFE549ED4560F896DB9E4452433DE993C8FC2FD4F525F0BDAD3764B151238D7E8D9B9589D00669D0E52BCCEE682E19A4AD3564AEB608A7B6744697BFA65DFA49EC95319A93A7A23B82CB3356A1371F3AE74DCFB8CF29C83D509906BADA3F3C87276D275B20566FD66B1D9EC38DA566FBAF024742D455E65661C31F38653F7D64275B705A45BC2838949C2B97D589D00946DD644009DE64EDD87E5FA798D25425BEFDA4EFD933EA7DC3916F292322F81BAE84D5D5EA435B1CC7E4B125CDACEEA04005E40275B0A0456CE04E6014A8ADA12B3AD89E5EFA7507969047E0AC626A6E85D8332978CAFF2C4E963BA949A543CD91A589D00944B7A873D3B2E26109553D274C55B626984738CF25C19E4F0D188330563ED002C039E0B7520953AF3A6AE3BDDACEE4BF4B83A01EA94191109745E4A10A1C15CEB3DC1D630E38DA94325873519E55D0920BFB2620F44A2277512BA1353B52CAC814D9680A0A366BB8045E7337E64B884B97B8260CC32D7B8CCDA73C6C6A8EAB27D9E864F7CC6E6B97CBB26401DAC933AEDCC7D1E120914DF1718276F26507388C4F84B1DBC04F29A347DFDD384210ED5E83162AD357936F5003015902730206CBE14E728794D2CDB66948CDFEF97A232D2F9493A997F2C33F3AD81CD0910B0777A80FEBDBC7306521971863D7A8A9ECA39A7DE774186968A0172CD97A0F2B6CDE9897434BD05AE420003738A6630D648A9D8E05CA8CFDB3E91B7B552B01432CA569846E6AE3B22B6A45DFAB976651D3D677CFA4288AD70350FE018935B2B50EA95EABB82928848BBBAD4DB1F4C2CBDC19A9875BAB63F9FA4765C7C29F96A6306816B7CF8F114AE1603F40F2D101133F77D2ED4D93B8748456102B1AD677FE275F33CF1B40564A8C67B29E65F0521FB56B8DA12601006C360A2DC4BA03EEEB698224F40696B9CC2BD0DEAB5DE23606D1B5304BCA4DDFA8DC482E408B0E58EE96A04E8533172E90E20250B2429BF7A897860066429B5DFCF61996F96955AF78BD273FD8CBFC6ABD980000ED11A13A26FB5B45D8D00CD5203B2A7EDFE25B08C3834516744E08A918027586B39A81E3B0EE46DC667A0DE78CA77699BE9C461D224D9569FA15D85009492B20CCA81C9A503519E78A7D0F94267F1AE2D078234B8C4281DBB5A72B8E2EA6F2C1DCD5E6AF8905EB497F1A597EC9ADE86AB10804B8E00846132E0B9A8AC54408604B30DC6A138B1871D82AD1523D5EE536DCFE7FAEDCD262F933112BF2D0511646D687B7A194BCC5A249BB80A019C01346B88DF6B216331B06D586D24B51B192C3F08E174CD018B972E8237A92F6CB85ECAB68C74BE3FEBE9DA1A6D095ADBF88D0726A9FBFE6F6D126C4E0083E1F253A08066AD77D9411BB9616D69631ABE3499C63C254B6393EA410AE469E667AC2D30096D49DBA2BDAB10C06C6A2058CDBD6D052410003AA16BE7C178DC6946ECDEFC9DA1A7944FAA2EE432EB5B4A6A6F0BA8DFACAF7F48BDB6F1E12A04285227CE00B6505ACA9986612C4663FCB99E4688A78C5D4AE9F6FB02B2DCFDB29DD2B5A15E7F58A32FFAA7BF5BB4B529017498213AB6A5546ECDFD640BCCFA0977CDEB30A4F5DFCC4244B35A64EF1A499D56FADA462C20A6986E3EB916B4A5AF11926C31713623400AA3C48E4C0DA23D73CA2C5D1B6FABB7F697F2363CF77C0B2CDF0AD2E5DAD89C00661E571A8B45E1B75066986DDFB21F2F014F94F12D03F3F3F4B5B02901B8ACE57ED6F6A941AC3D989762D9E6ADFBF314E66110B1555DBB8F9B1280CBEA483316DBCEF4D2648B35EDA5D893A127EA97543C92F111C1CEC6845AB3EFAB138051336EFB7F1293A59604EE0D3AB3DFAB41B6C63478A989C3D8193F11B40AA8FB0A6A8D09B43A01749ECCB759798049028220069C40E93DA1F133682FB8E6A499D7C4926A398049827374B73A016C9F1CFCE8B08EEBACEBB65E06D0F7F3C4FDE53BFC7306F21A31C7E9DA3B12B33CDD3571E6415AF7785193ECD225615502E88828FFD4003C63E83EA49883B14D9C01CE1AAE6DEF984633699C4134CBD39FB4BFABA41F464F77E9CFB90ACCFADE05AB13800B9B4798C4400C2017E765CB3C896BE01DB54684EA7C9F30C766AC0CEC787C1A5FCA5BA63330D3E7574244B9FE41AB73B13A01C0C0CCFA6638978FBDB635F278EEFDF67477A5D6BF7609985F9D13A7EEED19CB75DA6F6F22CDDE74445C9B187359047A702C5C3E429FEA28CFB924583D06A8430660800CDB9AAFD37DB86950D86B5B389540FC3EE50D5E23F43D224B8D1FC9FDCFA8CDF6C66F29F4FD81BC74544A17F2F7C18BBC7D5301E71A1F562700E818E1B60AFC0C1201CC7A9F373538E83F67CA0BC86F26C8EFD56BF541E96B81FE327CFF5249E3634CE2B7710BE8E4AB4C4237E5C963F6B7879E5F627CD88400D00004384860100D1ED3F3040DC44722296812C1B51963F9784D68FC086CFCED86A61EA4823F9E50DE7441C0CB206548A41133CC7CE53D179B1160020918BD814702469F2470C061D066FE24806B0AA4ACBC47035F4309EF8ADA5C4ACF8C83DB66F869C0C458C44833C8AB7CCB851849BECAA8A3FF32664D5C85003AED2BA096838C8A04B13F91D7BDCE12A60226110A14935BA0FE96EA93604D74AEAFF5798EC33658F0567C33513DD6F7CA3676638E1CCB7297E02A04A8D37982A9901918CAD320C17171DF12A48CC43D1F655A1A66996BA1318973B879CBD4EC9B34E313917D671D8DB57A4A49C69FB39FF19599E5D6C2E604981D36801913A41C33C67290122A23655CEE3077BA2402411264E98C7CB6B936EA13D23AAFAF4F527D91329EF55AD0E6608CF79B7D9AE39B6207A00E93A2FA10678B991FAEE201260C060928A76D4D6CCF13C0540CD8568A7E29475E4A572E4511BF7905714244581262D609F33ACC3E04D7FAC0E8F3E0A6BE474CBF893F86E51DDE86FAA23DCB823AE9A4315A06D5517FB6C0D509D080CD568A4A71066FE0F37023F8DD9A894045D695CB1852754A118C027986657DC1FD53CF52B8B6184060EABCA2FAEDC93376FD97B65B512EB856DFB29DF9DBCC57576350975801E12ABB1509AE4E8060502D072950CA701D8634F0795D5984B0A6162C228F3A5CCFFA7A6699B0D74630ED4EA3547F2208F52EBE83AC596FBF6B033110642E3FA76489EEF16A9348049110EFB93AD6C04D08D060A41447D106CEFD49298462CC9E39782925A7E8AE19CCB6AB803149A153DC47088633CB9082BB463ADB2C7D894CE59F75B92F9015ED23E0A93E26FA06F577C23D7BFA667E82D01D032F650BDCCC034C20C1F245076198530A965760D8AC0BF20A26BD6C62E0A57293A541E7EFE292392309CF241A17A5B7B6D7AFD9B744BF781AC4348EE5B3F9C56F6DCC355FBE6B6017040003EF2DE2344A47A4298594473066D6F200415E90CF7D8AA658B37A122243F77B1ABC67CAF012A78C3EAF2361BF45FDFAADBCBAF4B1E7FAA74FB37D6D0B5E2D6BE523D7C06E084089C4B689422888C1A4054479838C254D896D05CB1361320E30A2A50521E4577F7590792DDFB27C98F7E449EC3EF4B5FED5C7FE654F7D636863F2ACBEDB59D45F724DEC8200CD5A29455098483B8348B974339A829AC94B4512B3CE12607980943A154C2C1595CD605DABC33263462AB73438D467BF7988E28FFA41D4452C03FA238FFBFAEDBEB4BFFA9D6D5C13BBF10029165C5BE3536229974F99196A2ABCEB667546EC1B84EAA568861569CF7ACCCC0E9BAA8BEB9E86860CA50E5E4299B9B42CFB45049602C7798FF17BB1734BEC860013944D6CD93A3A6ED630EC54B2C04CECE0DE74E953D9669E755750A65E869D79942955C7F42C9D2324BC9059AB5FB5555DA59D19B89EF7136D2038E3ABF396D8250180622888C2E70E81D2A7913B33605C5BB3CE1512F91854DAE15065A5B3AEEA9E65791D7DB064A87F39DB675E44E471E45F3EEF1A39D405B79EFDB06B0F40B860EE567068F6770A97B1ACBFCDA4F273CDDC6E1E61690CF7FBC2A67B4964988238CA545F79A46D0FE7DB49EBFDB29E08D2E9DE5EB05B022C534A636C0A9F8A9D47C73325A2724A479C6910D7D3A03C8CC0D3D2D092E399BC11A7DFDDD30F4B01834246D52E02945F5DDAB7DE7B56BEBD9060B74BC012298FFBCC980C71EADD41685741ACB9ADDB19861798815879EDE1E529EE709D412D09F39452FE65FB48A1FE045140BEA7FA7A2BBC0A024CC599D51985CC28FF143CCB48FDAD5D04E21D327A70CDB845ED6D47EDEFE78B9E53860F4B02740EB047BC1A0F009468AD659848F01C012063F5472B9160BE299C7530F2FC031729E2C1A9FC4B4C0268CBD675AF7855048096800CE385CC5398C622F6FA195F793145CF27FC36E3E52DBFC8BE67333D858240A23C0FB057BC3A0258F3A76110E2940193F9BBB59D58D3ED1466DE3C85D4760D498875BF7FD9CCF389E56F3808B021B8ED4980B65FA7903133AC19AF0CA32A2FC8738E50B008AE11250F93119D01306C50DF53ED2E978083002B82112380596C6D9E86386514C6E539CCF80C2B555E2A1814D9F74D41E4906644795DCB83240583A7DA3B08B021CC584ACD2808D0EC0D8CE21EB77DEAF48E61BAC7D011A13A45FE1D3927199478C64BE459963896800DE1E38A8CC9108C3C67A36B5EC2E10E0364D8641A31C3CE67F31EC33927100394A77CD5C12398F193081D04D5F641809540C9F34B1A4A169D9B8952072E82B7692C922118CCB1ADE580D1A488D2E9A23A19BB33FD66388332B467935011C1990162CA57FE9EC977106025502E43A47C06A57846759DD23352B3D90B22C7BC7D9FCF4B48C1B5FB9612921167BEA44FBC10A176A4110211780C81694B8CE70701560465A6F0391B53B694F28977FE96830C780A337E785BBEE0B92F8BC400DAA8CD08415A32DC93E720C08AE85D7EC6779D11084F6029E81BBEE283A702368804930033EFF29E54BDCACD2073F6C93DBF5D1F0458011969EED19B81C416AF6F0273DD6B439D930444BF90CD777D2D43FA97D8655836F68A57E501287B9EE651B633FBFEA46C0BA33F87DAD4BE18A177089D2320C1E10156408A16A19BED0E6E046CD3F09300D724C36C9F0826E71F8E1E04580929D71742AE33BE34F87D6D687329FAC43321ACADEB5EF1EA82C0D70644D82A2659030701EE1C0701AE84C3031CD8250E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC390E02DC351E1EFE1F7A8CE869E4AF02FE0000000049454E44AE426082";
                //pbox_Spicture.Image = Properties.Resources._default;
            }
            tbox_Pid.Enabled = false;
            tbox_Sid.Enabled = false;

            byte[] _byte = HexStringToByteArray(picture);
            pbox_Spicture.Image = new Bitmap(new MemoryStream(_byte));
            if (dr["picture"] != DBNull.Value)
            {
                pbox_Spicture.Tag = picture;
            }
            else
            {
                pbox_Spicture.Tag = null;
            }

            dtp_reg.Enabled = false;
            panel29.Visible = false;
            panel30.Visible = false;
        }        
        /*DateTime Con_ToDate(object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return null;
            }
        }

        void ConvertFromInto<T>(object obj, out T result)
        {
            if( typeof(T) == typeof(DateTime))
            {
                result = Con_ToDate(obj);
            }
        }*/
        private void Display4Add2()
        {
            DataRow dr = App.Instance().DBManager.ReadInfo(App.Instance().parent_id, App.Instance().student_id);
            tbox_Pid.Text = App.Instance().parent_id;
            tbox_Pname.Text = Convert.ToString(dr["Pname"]);
            tbox_Pcontact.Text = Convert.ToString(dr["Pcontact"]);
            tbox_Pemail.Text = Convert.ToString(dr["Pemail"]);
            tbox_Pid.Enabled = false;
            tbox_Pname.Enabled = false;
            tbox_Pcontact.Enabled = false;
            tbox_Pemail.Enabled = false;
            tbox_Ppwd.Enabled = false;
            tbox_Saddr.Text = "";
            tbox_Scontact.Text = "";
            tbox_Sid.Text = "";
            tbox_Sname.Text = "";
            tbox_Spwd.Text = "";
            tbox_score.Text = "";
            dtp_reg.Value = DateTime.Now;
            rbtn_male.Checked = true;
            pbox_Spicture.Image = Properties.Resources._default;
        }
        private byte[] HexStringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            if (NumberChars % 2 == 0)
            {
                for (int i = 0; i < NumberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                }
            }
            return bytes;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if(m_PopMode == ePopMode.Add)
            {
                save4Add();
            }
            else if(m_PopMode == ePopMode.Modify)
            {
                save4Modify();
            }
            else if (m_PopMode == ePopMode.Add2)
            {
                save4Add2();
            }
        }
        private void btn_init_Click(object sender, EventArgs e)
        {
            Display();
        }
        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|all files|*.*";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox_Spicture.Image = Bitmap.FromFile(ofd.FileName);

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read); ;
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);

                StringBuilder hex = new StringBuilder(bImage.Length * 2);
                foreach (byte b in bImage)
                {
                    hex.AppendFormat("{0:X2}", b);
                }
                string _hex_image = hex.ToString();
                //MessageBox.Show(_hex_image);
                pbox_Spicture.Tag = _hex_image;
            }
        }
        private bool Validation()
        {
            bool _result = true;
            string _msg = "";

            //필수입력
            if (tbox_Pname.Text.Length <= 0 || tbox_Sname.Text.Length <= 0)
            {
                if (_msg.Length == 0) 
                { 
                    //tbox_Pname.Focus(); 
                }
                _msg += "이름은 필수입력사항입니다.";
            }
            if (tbox_Pid.Text.Length <= 0 || tbox_Sid.Text.Length <= 0)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Pid.Focus();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "아이디는 필수입력사항입니다.";
            }
            if (tbox_Ppwd.Text.Length <= 0 || tbox_Spwd.Text.Length <= 0)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Ppwd.Focus();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "비밀번호는 필수입력사항입니다.";
            }
            //문자타입길이체크
            //문자열리터럴체크

            string pattern = @"^\d{3}-\d{4}-\d{4}$";
            //전화번호 형식체크 000-0000-0000
            if (Regex.IsMatch(tbox_Pcontact.Text, pattern) == false || Regex.IsMatch(tbox_Scontact.Text, pattern) == false)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Pcontact.Focus(); tbox_Pcontact.SelectAll();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "전화번호 형식이 올바르지 않습니다.";
            }
            //아이디중복체크
            if (_msg.Length == 0)
            {
                bool _check_id = true;
                if (App.Instance().parent_id != null && App.Instance().parent_id == tbox_Pid.Text)
                {
                    //수정모드이면서 아이디가 안바뀌면
                    _check_id = false;
                }
                if (_check_id)
                {
                    DataTable _dt = App.Instance().DBManager.ReadMember(tbox_Pid.Text);
                    if (_dt != null && _dt.Rows != null && _dt.Rows.Count > 0)
                    {
                        _msg += string.Format(" [{0}]는 사용중인 아이디 입니다.", tbox_Pid.Text);
                        tbox_Pid.Focus();
                        tbox_Pid.SelectAll();
                    }
                    DataTable dt = App.Instance().DBManager.ReadMember(tbox_Sid.Text);
                    if(dt != null && dt.Rows != null && dt.Rows.Count > 0)
                    {
                        _msg += string.Format(" [{0}]는 사용중인 아이디 입니다.", tbox_Sid.Text);
                        tbox_Sid.Focus(); 
                        tbox_Sid.SelectAll();
                    }
                }
            }
            //
            if (_msg.Length > 0)
            {
                _result = false;
                MessageBox.Show(_msg);
            }
            return _result;
        }
        private bool Validation2()
        {
            bool _result = true;
            string _msg = "";

            //필수입력
            if (tbox_Pname.Text.Length <= 0 || tbox_Sname.Text.Length <= 0)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Pname.Focus(); 
                }
                _msg += "이름은 필수입력사항입니다.";
            }
            if (tbox_Pid.Text.Length <= 0 || tbox_Sid.Text.Length <= 0)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Pid.Focus();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "아이디는 필수입력사항입니다.";
            }
            if (tbox_Spwd.Text.Length <= 0)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Ppwd.Focus();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "비밀번호는 필수입력사항입니다.";
            }
            //문자타입길이체크
            //문자열리터럴체크

            string pattern = @"^\d{3}-\d{4}-\d{4}$";
            //전화번호 형식체크 000-0000-0000
            if (Regex.IsMatch(tbox_Pcontact.Text, pattern) == false || Regex.IsMatch(tbox_Scontact.Text, pattern) == false)
            {
                if (_msg.Length == 0)
                {
                    //tbox_Pcontact.Focus(); tbox_Pcontact.SelectAll();
                }
                else
                {
                    _msg += "\r\n";
                }
                _msg += "전화번호 형식이 올바르지 않습니다.";
            }
            //아이디중복체크
            if (_msg.Length == 0)
            {
                bool _check_id = true;
                if (App.Instance().parent_id != null && App.Instance().parent_id == tbox_Pid.Text)
                {
                    //수정모드이면서 아이디가 안바뀌면
                    _check_id = false;
                }
                if (_check_id)
                {
                    DataTable _dt = App.Instance().DBManager.ReadMember(tbox_Pid.Text);
                    if (_dt != null && _dt.Rows != null && _dt.Rows.Count > 0)
                    {
                        _msg += string.Format(" [{0}]는 사용중인 아이디 입니다.", tbox_Pid.Text);
                        tbox_Pid.Focus();
                        tbox_Pid.SelectAll();
                    }
                    DataTable dt = App.Instance().DBManager.ReadMember(tbox_Sid.Text);
                    if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                    {
                        _msg += string.Format(" [{0}]는 사용중인 아이디 입니다.", tbox_Sid.Text);
                        tbox_Sid.Focus();
                        tbox_Sid.SelectAll();
                    }
                }
            }
            //
            if (_msg.Length > 0)
            {
                _result = false;
                MessageBox.Show(_msg);
            }
            return _result;
        }
        private void save4Add()
        {
            if (Validation())
            {
                string PId = tbox_Pid.Text;
                string PPwd = tbox_Ppwd.Text;
                string PName = tbox_Pname.Text;
                string PContact = tbox_Pcontact.Text;
                string PEmail = tbox_Pemail.Text;
                string SId = tbox_Sid.Text;
                string SPwd = tbox_Spwd.Text;
                string SName = tbox_Sname.Text;
                string SGender = (rbtn_male.Checked) ? "M" : "W";
                string SContact = tbox_Scontact.Text;
                string SAddr = tbox_Saddr.Text;
                DateTime SRegDate = dtp_reg.Value;
                string SScore = null;
                string SPic = null;
                if (pbox_Spicture.Tag != null)
                {
                    SPic = pbox_Spicture.Tag.ToString();
                }
                if (tbox_score.Text.Length > 0)
                {
                    SScore = tbox_score.Text;
                }
                int result = App.Instance().DBManager.AddMember(PId, PPwd, PName, PContact, PEmail, SId, SPwd, SName, SGender, SContact, SAddr, SRegDate, SScore, SPic);
                if (result > 0)
                {
                    MessageBox.Show("회원가입 성공");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("회원가입 실패");
                }
            }
        }
        private void save4Modify()
        {
            if (Validation())
            {
                string PId = tbox_Pid.Text;
                string PPwd = tbox_Ppwd.Text;
                string PName = tbox_Pname.Text;
                string PContact = tbox_Pcontact.Text;
                string PEmail = tbox_Pemail.Text;
                string SId = tbox_Sid.Text;
                string SPwd = tbox_Spwd.Text;
                string SName = tbox_Sname.Text;
                string SGender = (rbtn_male.Checked) ? "M" : "W";
                string SContact = tbox_Scontact.Text;
                string SAddr = tbox_Saddr.Text;
                string SPic = null;
                if (pbox_Spicture.Tag != null)
                {
                    SPic = pbox_Spicture.Tag.ToString();
                }
                int result = App.Instance().DBManager.ModifyMember(PId, PPwd, PName, PContact, PEmail, SId, SPwd, SName, SGender, SContact, SAddr, SPic);
                if (result > 0)
                {
                    MessageBox.Show("정보수정 성공");
                    App.Instance().parent_id = PId;
                    App.Instance().student_id = SId;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("정보수정 실패");
                }
            }
        }
        private void save4Add2()
        {
            if (Validation2())
            {
                string SId = tbox_Sid.Text;
                string SPwd = tbox_Spwd.Text;
                string SName = tbox_Sname.Text;
                string SGender = (rbtn_male.Checked) ? "M" : "W";
                string SContact = tbox_Scontact.Text;
                string SAddr = tbox_Saddr.Text;
                DateTime SRegDate = dtp_reg.Value;
                string SScore = null;
                string SPic = null;
                if (pbox_Spicture.Tag != null)
                {
                    SPic = pbox_Spicture.Tag.ToString();
                }
                if (tbox_score.Text.Length > 0)
                {
                    SScore = tbox_score.Text;
                }
                int result = App.Instance().DBManager.AddMember(SId, SPwd, SName, SGender, SContact, SAddr, SRegDate, SScore, SPic);
                if (result > 0)
                {
                    MessageBox.Show("추가 성공");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("추가 실패");
                }
            }
        }
    }
}