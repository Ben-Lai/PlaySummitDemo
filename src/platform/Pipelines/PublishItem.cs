using Sitecore.Diagnostics;
using Sitecore.Publishing;
using Sitecore.Publishing.Pipelines.Publish;
using Sitecore.Publishing.Pipelines.PublishItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Demo.Edge.Website.Pipelines
{
    public class PublishItem : PublishProcessor
    {

        public override void Process(PublishContext context)
        {

            Log.Info("Beginning PublishAudit Log", this);
            var processedItems = context.ProcessedPublishingCandidates;
            foreach (var processedItem in processedItems)
            {
                Log.Info("[PublishAudit] Publishing Item: " + processedItem.Key.ItemId.ToString(), this);
            }
            Log.Info("Finished PublishAudit Log", this);

        }
    }
}