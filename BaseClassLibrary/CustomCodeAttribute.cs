namespace Service.Base.Attributes.ModelAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.All, AllowMultiple = false)]
    public class CustomAutoCodeAttribute : Attribute
    {
        //Nothing
        //Will be updated custom code by related functions.
    }
}
