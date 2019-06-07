using System;
using System.Activities;
using System.Threading;
using WolframLanguage.Activities.Properties;

namespace WolframLanguage.Activities.Activities.Low_Level.Packet_Management
{
    [LocalizedDisplayName(nameof(Resources.FlushActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.FlushActivityDescription))]
    public class FlushActivity : NativeActivity
    {
        #region Overrides of NativeActivity

        protected override void Execute(NativeActivityContext context)
        {
            var client = (Application) context.Properties.Find(@"Application");
            while (client == null || !client.Ready)
            {
                Console.WriteLine(Resources.WolframLanguageScope_Execute_Waiting_for_client_to_be_ready___);
                Thread.Sleep(100);
            }
            
            client.Flush();
        }

        #endregion
    }
}
