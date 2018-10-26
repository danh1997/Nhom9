using Abp.Web.Mvc.Views;

namespace HuflitBigPrj.Web.Views
{
    public abstract class HuflitBigPrjWebViewPageBase : HuflitBigPrjWebViewPageBase<dynamic>
    {

    }

    public abstract class HuflitBigPrjWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected HuflitBigPrjWebViewPageBase()
        {
            LocalizationSourceName = HuflitBigPrjConsts.LocalizationSourceName;
        }
    }
}