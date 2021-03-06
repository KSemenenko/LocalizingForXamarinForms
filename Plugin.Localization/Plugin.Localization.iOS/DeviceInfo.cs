﻿//using System;
//using Foundation;
//using Plugin.Localization.Abstractions;
//using Plugin.Localization.Abstractions.Model;
//using UIKit;
//using System.IO;

//namespace Plugin.Localization
//{
//    public class DeviceInfo : IDeviceInfo
//    {
//        private readonly string LocalizationFolder = "ga-store";

//        public DeviceInfo()
//        {
//            UIWebView agentWebView = new UIWebView();
//            UserAgent = agentWebView.EvaluateJavascript("navigator.userAgent");
//            Display = new Dimensions(Convert.ToInt32(UIScreen.MainScreen.Bounds.Size.Height), Convert.ToInt32(UIScreen.MainScreen.Bounds.Size.Width));

//            LocalizationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), LocalizationFolder);
//        }

//        public string Id
//        {
//            get { return UIDevice.CurrentDevice.IdentifierForVendor.AsString(); }
//        }

//        public string UserAgent { get; set; }

//        public string Version
//        {
//            get { return NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString(); }
//        }

//        public Version VersionNumber
//        {
//            get
//            {
//                try
//                {
//                    return new Version(Version);
//                }
//                catch
//                {
//                    return new Version();
//                }
//            }
//        }

//        public string LanguageCode
//        {
//            get { return NSLocale.PreferredLanguages[0]; }
//        }

//        public Dimensions Display { get; set; }
//        public Dimensions ViewPortResolution { get; set; }

//        public string GenerateAppId(bool usingPhoneId = false, string prefix = null, string suffix = null)
//        {
//            var appId = "";

//            if (!string.IsNullOrEmpty(prefix))
//            {
//                appId += prefix;
//            }

//            appId += Guid.NewGuid().ToString();

//            if (usingPhoneId)
//            {
//                appId += Id;
//            }

//            if (!string.IsNullOrEmpty(suffix))
//            {
//                appId += suffix;
//            }

//            return appId;
//        }

//        public string ReadFile(string path)
//        {
//            if (!File.Exists(Path.Combine(LocalizationFolder, path)))
//            {
//                return string.Empty;
//            }

//            return File.ReadAllText(Path.Combine(LocalizationFolder, path));
//        }

//        public void WriteFile(string path, string content)
//        {
//            if (!Directory.Exists(LocalizationFolder))
//            {
//                Directory.CreateDirectory(LocalizationFolder);
//            }
//            File.WriteAllText(Path.Combine(LocalizationFolder, path), content);
//        }
//    }
//}

