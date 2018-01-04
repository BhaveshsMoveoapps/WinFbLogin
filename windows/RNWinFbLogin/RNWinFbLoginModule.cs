using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Win.Fb.Login.RNWinFbLogin
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWinFbLoginModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNWinFbLoginModule"/>.
        /// </summary>
        internal RNWinFbLoginModule()
        {

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
        public void login(ICallback errorCallback, ICallback successCallback)
        {
            RunOnDispatcher(async () => {
                try
                {
                    successCallback.Invoke("Yehhhhh");

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
