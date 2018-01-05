using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Security.Authentication.Web;
using Windows.UI.Core;
using winsdkfb;

namespace Win.Fb.Login.RNWinFbLogin
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWinFbLoginModule : NativeModuleBase
    {

        string SID = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();

        FBSession _session;
        FBPermissions _permissions;

        /// <summary>
        /// Instantiates the <see cref="RNWinFbLoginModule"/>.
        /// </summary>
        internal RNWinFbLoginModule()
        {
        }

        public async Task<object> LoginAsync()
        {
            if (_session != null)
            {
                var result = await _session.LoginAsync(_permissions);

                if (result.Succeeded)
                {
                    return result;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNWinFbLogin";
            }
        }

        [ReactMethod]
        public void initializeFbSession(String AppID, ICallback errorCallback, ICallback successCallback)
        {
            _session = FBSession.ActiveSession;
            _session.WinAppId = SID;
            _session.FBAppId = AppID;

            List<string> permissionList = new List<string>();
            permissionList.Add("public_profile");
            permissionList.Add("email");

            _permissions = new FBPermissions(permissionList);
            successCallback.Invoke("Initialized");
        }

        [ReactMethod]
        public void login(ICallback errorCallback, ICallback successCallback)
        {

            RunOnDispatcher(async () =>
            {
                try
                {
                    var result = await _session.LoginAsync(_permissions);
                    if (result.Succeeded)
                    {
                        successCallback.Invoke(result);
                        //do something
                    }
                    else
                    {
                        errorCallback.Invoke("not_available errorororor");
                    }
                    // var reslut = LoginAsync();
                    // successCallback.Invoke(reslut);

                }
                catch
                {
                    errorCallback.Invoke("not_available");
                }
            });
        }


        private static async void RunOnDispatcher(DispatchedHandler action)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, action);
        }
    }

}
