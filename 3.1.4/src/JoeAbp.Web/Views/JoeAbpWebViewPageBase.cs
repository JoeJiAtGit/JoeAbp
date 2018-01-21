using Abp.Web.Mvc.Views;

namespace JoeAbp.Web.Views
{
    public abstract class JoeAbpWebViewPageBase : JoeAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class JoeAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JoeAbpWebViewPageBase()
        {
            LocalizationSourceName = JoeAbpConsts.LocalizationSourceName;
        }
    }
}