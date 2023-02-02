//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Text;

//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Security;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic;
//using System.Data;
//using System.Drawing.Printing;
//using System.Drawing;
//using System.Windows.Forms;

//namespace LoadPermissionPrinting
//{
//    public struct R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf
//    {
//        public Int64 LoadAllocationId;
//        public Int64 nEstelamId;
//        public string TurnId;
//        public string LoadPermissionDate;
//        public string LoadPermissionTime;
//        public string TransportCompany;
//        public string CarType;
//        public string LoaderType;
//        public string TruckLP;
//        public string TruckLPSerial;
//        public string TruckDriver;
//        public string TruckDriverDrivingLicenseNo;
//        public string GoodName;
//        public string TargetCity;
//        public string SourceCity;
//        public string TransportPrice;
//        public string LoadCapacitorLoadDescription;
//        public string UserName;
//        public string OtherNote;
//        public string Tonaj;
//    }

//    public class R2CoreTransportationAndLoadNotificationInstanceLoadPermissionPrintingManager
//    {
//        R2CoreTransportationAndLoadNotificationInstanceLoadPermissionPrintingManager()
//        {
//            _PrintDocumentPermission = new PrintDocument();
//        }

//        private PrintDocument __PrintDocumentPermission;

//        private PrintDocument _PrintDocumentPermission
//        {
//            [MethodImpl(MethodImplOptions.Synchronized)]
//            get
//            {
//                return __PrintDocumentPermission;
//            }

//            [MethodImpl(MethodImplOptions.Synchronized)]
//            set
//            {
//                if (__PrintDocumentPermission != null)
//                {
//                    __PrintDocumentPermission.BeginPrint -= _PrintDocumentPermission_BeginPrint;
//                    __PrintDocumentPermission.EndPrint -= _PrintDocumentPermission_EndPrint;
//                    __PrintDocumentPermission.PrintPage -= _PrintDocumentPermission_PrintPage;
//                }

//                __PrintDocumentPermission = value;
//                if (__PrintDocumentPermission != null)
//                {
//                    __PrintDocumentPermission.BeginPrint += _PrintDocumentPermission_BeginPrint;
//                    __PrintDocumentPermission.EndPrint += _PrintDocumentPermission_EndPrint;
//                    __PrintDocumentPermission.PrintPage += _PrintDocumentPermission_PrintPage;
//                }
//            }
//        }

//        private R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf _PPDS;

//        public R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf GetLoadPermissionPrintingInf(Int64 YourLoadAllocationId)
//        {
//            try
//            {
//                var InstanceSqlDataBox = new R2CoreInstanseSqlDataBOXManager();
//                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
//                DataSet DS;
//                InstanceSqlDataBox.GetDataBOX(new R2PrimarySqlConnection(), @"Select LoadAllocation.LAId,LoadAllocation.nEstelamId,Substring(EnterExit.OtaghdarTurnNumber,7,20) as TurnId,EnterExit.strExitDate,EnterExit.strExitTime
//                                  ,TransportCompany.TCTitle,LoaderType.LoaderTypeTitle,CarType.strCarName as CarType,Car.strCarNo as Truck,Car.strCarSerialNo as TruckSerial,Person.strPersonFullName
//	                              ,Driver.strDrivingLicenceNo,Product.strGoodName,CityTarget.strCityName as TargetCity,CitySource.strCityName as SourceCity,Elam.nTonaj,Elam.strPriceSug,Elam.strDescription,Elam.StrAddress,Elam.strBarName,SoftwareUser.UserName,CityTarget.nDistance/25 as TravelLength
//                           from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocation
//                                Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
//                                Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
//                                Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompany On Elam.nCompCode=TransportCompany.TCId
//                                Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar 
//                                Inner Join dbtransport.dbo.tbCarType as CarType On Car.snCarType=CarType.snCarType 
//                                Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LoaderType On Car.snCarType=LoaderType.LoaderTypeId
//								Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
//                                Inner Join dbtransport.dbo.TbDriver as Driver On EnterExit.nDriverCode=Driver.nIDDriver
//                                Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode
//                                Inner Join dbtransport.dbo.tbCity as CityTarget On Elam.nCityCode=CityTarget.nCityCode
//                                Inner Join dbtransport.dbo.tbCity as CitySource On Elam.nBarSource=CitySource.nCityCode
//                                Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUser On LoadAllocation.UserId=SoftwareUser.UserId
//                           Where LoadAllocation.LAId=" + YourLoadAllocationId + "", 1, DS);
//                R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf LoadPermissionPrintingInf = new R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf();
//                LoadPermissionPrintingInf.LoadAllocationId = DS.Tables(0).Rows(0).Item("LAId");
//                LoadPermissionPrintingInf.nEstelamId = DS.Tables(0).Rows(0).Item("nEstelamId");
//                LoadPermissionPrintingInf.TurnId = DS.Tables(0).Rows(0).Item("TurnId");
//                LoadPermissionPrintingInf.LoadPermissionDate = DS.Tables(0).Rows(0).Item("strExitDate").trim;
//                LoadPermissionPrintingInf.LoadPermissionTime = DS.Tables(0).Rows(0).Item("strExitTime").trim;
//                LoadPermissionPrintingInf.TransportCompany = DS.Tables(0).Rows(0).Item("TCTitle").trim;
//                LoadPermissionPrintingInf.CarType = DS.Tables(0).Rows(0).Item("CarType").trim;
//                LoadPermissionPrintingInf.LoaderType = DS.Tables(0).Rows(0).Item("LoaderTypeTitle").trim;
//                LoadPermissionPrintingInf.TruckLP = DS.Tables(0).Rows(0).Item("Truck").trim;
//                LoadPermissionPrintingInf.TruckLPSerial = DS.Tables(0).Rows(0).Item("TruckSerial").trim;
//                LoadPermissionPrintingInf.TruckDriver = DS.Tables(0).Rows(0).Item("strPersonFullName").trim;
//                LoadPermissionPrintingInf.TruckDriverDrivingLicenseNo = DS.Tables(0).Rows(0).Item("strDrivingLicenceNo").trim;
//                LoadPermissionPrintingInf.GoodName = DS.Tables(0).Rows(0).Item("strGoodName").trim;
//                LoadPermissionPrintingInf.TargetCity = DS.Tables(0).Rows(0).Item("TargetCity").trim;
//                LoadPermissionPrintingInf.SourceCity = DS.Tables(0).Rows(0).Item("SourceCity").trim;
//                LoadPermissionPrintingInf.TransportPrice = DS.Tables(0).Rows(0).Item("strPriceSug").trim;
//                LoadPermissionPrintingInf.LoadCapacitorLoadDescription = DS.Tables(0).Rows(0).Item("strDescription").trim + " " + DS.Tables(0).Rows(0).Item("StrAddress").trim + " " + DS.Tables(0).Rows(0).Item("StrBarName").trim;
//                LoadPermissionPrintingInf.UserName = DS.Tables(0).Rows(0).Item("UserName").trim;
//                LoadPermissionPrintingInf.OtherNote = Convert.ToString(DS.Tables(0).Rows(0).Item("TravelLength")) + "مدت سفر:";
//                LoadPermissionPrintingInf.Tonaj = Convert.ToString(DS.Tables(0).Rows(0).Item("nTonaj"));
//                return LoadPermissionPrintingInf;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }

//        public void PrintLoadPermission(Int64 YourLoadAllocationId)
//        {
//            try
//            {
//                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
//                var InstanceConfigurationOfAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceConfigurationOfAnnouncementHallsManager();
//                _PPDS = GetLoadPermissionPrintingInf(YourLoadAllocationId);
//                // چاپ مجوز
//                var NSSLoadCapacitorLoad = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId, true);
//                string ComposeSearchString = NSSLoadCapacitorLoad.AHSGId.ToString + "=";
//                string[] AllAnnouncementHallPrinters = Split(InstanceConfigurationOfAnnouncementHalls.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 3), "-");
//                string AnnouncementHallSubGroupPrinter = Strings.Mid(AllAnnouncementHallPrinters.Where(x => Strings.Mid(x, 1, ComposeSearchString.Length) == ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnouncementHallPrinters.Where(x => Strings.Mid(x, 1, ComposeSearchString.Length) == ComposeSearchString)(0).Length);
//                // _PrintDocumentPermission.PrinterSettings.PrinterName = AnnouncementHallSubGroupPrinter.Trim
//                _PrintDocumentPermission.PrinterSettings.PrinterName = "HP LaserJet 400 MFP M425 PCL 6 (redirected 2)";
//                _PrintDocumentPermission.DefaultPageSettings.PaperSize = _PrintDocumentPermission.PrinterSettings.PaperSizes(4);
//                _PrintDocumentPermission.DefaultPageSettings.PaperSource = _PrintDocumentPermission.PrinterSettings.PaperSources(2);
//                _PrintDocumentPermission.Print();
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }

//        private void _PrintDocumentPermission_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
//        {
//        }

//        private void _PrintDocumentPermission_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
//        {
//        }

//        private void A4Printing(System.Drawing.Printing.PrintPageEventArgs YourEventArgs, Int16 X, Int16 Y)
//        {
//            try
//            {
//                int myPaperSizeHalf = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / (double)4;
//                Font myStrFontSuperMax = new System.Drawing.Font("Badr", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myStrFontMax = new System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myStrFontMin = new System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myDigFont = new System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(2));
//                // مرحله اول
//                YourEventArgs.Graphics.DrawRectangle(new Pen(Brushes.Black, 5), X, Y, 700, 400);
//                YourEventArgs.Graphics.DrawImage(My.Resources.QRCodeLight, X + 40, Y + 60, 120, 120);
//                YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y);
//                YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 280, Y + 50);
//                YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMax, Brushes.DarkBlue, X + 30, Y);
//                YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y);
//                YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 30);
//                YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMax, Brushes.DarkBlue, X + 30, Y + 30);
//                YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 60);
//                YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 130);
//                char[] a;
//                if (_PPDS.TruckLP.Trim() != string.Empty)
//                {
//                    YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170);
//                    a = _PPDS.TruckLP.ToCharArray();
//                    YourEventArgs.Graphics.DrawString(a[4], myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[5], myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[3], myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[0], myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[1], myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[2] + " به شماره پلاک ", myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170);
//                }
//                YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMax, Brushes.DarkBlue, X + 400, Y + 170);
//                YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210);
//                YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210);
//                YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 240);
//                YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 300, Y + 240);
//                YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 240);
//                YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMax, Brushes.DarkBlue, X + 450, Y + 270);
//                YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMax, Brushes.DarkBlue, X + 100, Y + 270);
//                YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 290);
//                // E.Graphics.DrawString("توجه : ", myStrFontMax, Brushes.DarkBlue, X + 650, Y + 310)
//                YourEventArgs.Graphics.DrawString(" توجه: مجوز فوق پس از صدور تعويض نخواهد شد - دريافت نوبت بعدی از پايانه به شرط انجام سفر امکان پذير است", myStrFontMax, Brushes.DarkBlue, X + 10, Y + 340);
//                YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 360);
//                YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMax, Brushes.DarkBlue, X + 300, Y + 360);
//                // مرحله دوم
//                Y = Y + 550;
//                YourEventArgs.Graphics.DrawRectangle(new Pen(Brushes.Black, 5), X, Y, 700, 400);
//                YourEventArgs.Graphics.DrawImage(My.Resources.QRCodeLight, X + 40, Y + 60, 120, 120);
//                YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y);
//                YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 280, Y + 50);
//                YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMax, Brushes.DarkBlue, X + 30, Y);
//                YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y);
//                YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 30);
//                YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMax, Brushes.DarkBlue, X + 30, Y + 30);
//                YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 60);
//                YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 130);
//                if (_PPDS.TruckLP.Trim() != string.Empty)
//                {
//                    YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[4], myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[5], myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[3], myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[0], myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[1], myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170);
//                    YourEventArgs.Graphics.DrawString(a[2] + " به شماره پلاک ", myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170);
//                }
//                YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMax, Brushes.DarkBlue, X + 400, Y + 170);
//                YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210);
//                YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210);
//                YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 240);
//                YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 300, Y + 240);
//                YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 240);
//                YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMax, Brushes.DarkBlue, X + 450, Y + 270);
//                YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMax, Brushes.DarkBlue, X + 100, Y + 270);
//                YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 290);
//                // E.Graphics.DrawString("توجه : ", myStrFontMax, Brushes.DarkBlue, X + 650, Y + 310)
//                YourEventArgs.Graphics.DrawString(" توجه: مجوز فوق پس از صدور تعويض نخواهد شد - دريافت نوبت بعدی از پايانه به شرط انجام سفر امکان پذير است", myStrFontMax, Brushes.DarkBlue, X + 10, Y + 340);
//                YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 360);
//                YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMax, Brushes.DarkBlue, X + 300, Y + 360);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }

//        private void A5Printing(System.Drawing.Printing.PrintPageEventArgs YourEventArgs, Int16 X, Int16 Y)
//        {
//            try
//            {
//                int myPaperSizeHalf = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / (double)4;
//                Font myStrFontSuperMax = new System.Drawing.Font("Badr", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myStrFontUpperMax = new System.Drawing.Font("Badr", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myStrFontMax = new System.Drawing.Font("Badr", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myStrFontMin = new System.Drawing.Font("Badr", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
//                Font myDigFont = new System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(2));
//                // مرحله اول
//                YourEventArgs.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), X, Y, 520, 350);
//                YourEventArgs.Graphics.DrawImage(My.Resources.QRCodeLight, X + 30, Y + 60, 75, 75);
//                YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y);
//                YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 195, Y + 30);
//                YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 20);
//                YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 20);
//                YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 40);
//                YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 40);
//                YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 60);
//                YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontSuperMax, Brushes.DarkBlue, X + 160, Y + 80);
//                char[] a;
//                if (_PPDS.TruckLP.Trim() != string.Empty)
//                {
//                    a = _PPDS.TruckLP.ToCharArray();
//                    YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontSuperMax, Brushes.DarkBlue, X + 20, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[4], myStrFontSuperMax, Brushes.DarkBlue, X + 60, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[5], myStrFontSuperMax, Brushes.DarkBlue, X + 70, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[3], myStrFontSuperMax, Brushes.DarkBlue, X + 80, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[0], myStrFontSuperMax, Brushes.DarkBlue, X + 90, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[1], myStrFontSuperMax, Brushes.DarkBlue, X + 100, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[2] + " پلاک ", myStrFontSuperMax, Brushes.DarkBlue, X + 110, Y + 120);
//                }
//                YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMin, Brushes.DarkBlue, X + 300, Y + 120);
//                YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, X + 150, Y + 140);
//                YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMin, Brushes.DarkBlue, X + 20, Y + 170);
//                YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 180);
//                YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 180);
//                YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 330, Y + 210);
//                YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 240);
//                YourEventArgs.Graphics.DrawString("            ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 240);

//                YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMin, Brushes.DarkBlue, X + 125, Y + 240);
//                YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 260);
//                YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMin, Brushes.DarkBlue, X + 50, Y + 280);
//                YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMin, Brushes.DarkBlue, X + 165, Y + 280);
//                // مرحله دوم
//                Y = Y + 400;
//                YourEventArgs.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), X, Y, 520, 350);
//                YourEventArgs.Graphics.DrawImage(My.Resources.QRCodeLight, X + 30, Y + 60, 75, 75);
//                YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y);
//                YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 195, Y + 30);
//                YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 20);
//                YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 20);
//                YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 40);
//                YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 40);
//                YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 360, Y + 60);
//                YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontSuperMax, Brushes.DarkBlue, X + 160, Y + 80);
//                if (_PPDS.TruckLP.Trim() != string.Empty)
//                {
//                    a = _PPDS.TruckLP.ToCharArray();
//                    YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontSuperMax, Brushes.DarkBlue, X + 20, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[4], myStrFontSuperMax, Brushes.DarkBlue, X + 60, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[5], myStrFontSuperMax, Brushes.DarkBlue, X + 70, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[3], myStrFontSuperMax, Brushes.DarkBlue, X + 80, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[0], myStrFontSuperMax, Brushes.DarkBlue, X + 90, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[1], myStrFontSuperMax, Brushes.DarkBlue, X + 100, Y + 120);
//                    YourEventArgs.Graphics.DrawString(a[2] + " پلاک ", myStrFontSuperMax, Brushes.DarkBlue, X + 110, Y + 120);
//                }
//                YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMin, Brushes.DarkBlue, X + 300, Y + 120);
//                YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, X + 150, Y + 140);
//                YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMin, Brushes.DarkBlue, X + 20, Y + 170);
//                YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 180);
//                YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 180);
//                YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 330, Y + 210);
//                YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 240);
//                YourEventArgs.Graphics.DrawString("            ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 240);
//                YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMin, Brushes.DarkBlue, X + 125, Y + 240);
//                YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 260);
//                YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMin, Brushes.DarkBlue, X + 50, Y + 280);
//                YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMin, Brushes.DarkBlue, X + 165, Y + 280);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }

//        private void _PrintDocumentPermission_PrintPage_Printing(Int16 X, Int16 Y, System.Drawing.Printing.PrintPageEventArgs E)
//        {
//            try
//            {
//                var InstanceConfigurationOfAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceConfigurationOfAnnouncementHallsManager();
//                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
//                string ConfiguredPageType = InstanceConfigurationOfAnnouncementHalls.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId, true).AHId, 0);
//                if (Enum.Parse(typeof(System.Drawing.Printing.PaperKind), ConfiguredPageType) == System.Drawing.Printing.PaperKind.A5)
//                    A5Printing(E, 10, 20);
//                else if (Enum.Parse(typeof(System.Drawing.Printing.PaperKind), ConfiguredPageType) == System.Drawing.Printing.PaperKind.A4)
//                    A4Printing(E, 50, 80);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }

//        private void _PrintDocumentPermission_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
//        {
//            try
//            {
//                _PrintDocumentPermission_PrintPage_Printing(0, 0, e);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + Constants.vbCrLf + ex.Message);
//            }
//        }
//    }
//}
