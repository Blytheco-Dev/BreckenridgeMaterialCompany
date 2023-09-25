using PX.Data;

namespace BlyOnBase
{
    public class APRegisterExt : PXCacheExtension<PX.Objects.AP.APRegister>
  {
    #region UsrBlyOnBaseURL
    [PXDBWeblink]
    [PXUIField(DisplayName="OnBase URL")]

    public virtual string UsrBlyOnBaseURL { get; set; }
    public abstract class usrBlyOnBaseURL : PX.Data.BQL.BqlString.Field<usrBlyOnBaseURL> { }
    #endregion
  }
}