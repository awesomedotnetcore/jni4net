// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.builder;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class DecisionTableConfiguration_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.builder.DecisionTableConfiguration_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.builder.DecisionTableConfiguration_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __DecisionTableConfiguration extends system.Object implements org.drools.builder.DecisionTableConfiguration {
    
    protected __DecisionTableConfiguration(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/builder/DecisionTableInputType;)V")
    public native void setInputType(org.drools.builder.DecisionTableInputType par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/builder/DecisionTableInputType;")
    public native org.drools.builder.DecisionTableInputType getInputType();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)V")
    public native void setWorksheetName(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getWorksheetName();
}
//</generated-proxy>
