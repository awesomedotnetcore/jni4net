//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Double : global::java.lang.Number, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_doubleToRawLongBits1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_doubleToLongBits2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_longBitsToDouble3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toHexString5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toString6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compare7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isNaN10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isNaN11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInfinite12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInfinite13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_parseDouble14;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_POSITIVE_INFINITY15;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_NEGATIVE_INFINITY16;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_NaN17;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_MAX_VALUE18;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_MIN_VALUE19;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SIZE20;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_TYPE21;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDouble22;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDouble23;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)V")]
        public Double(double par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Double.staticClass, global::java.lang.Double.j4n__ctorDouble22, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Double(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Double.staticClass, global::java.lang.Double.j4n__ctorDouble23, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        protected Double(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Double.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double POSITIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_POSITIVE_INFINITY15)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double NEGATIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_NEGATIVE_INFINITY16)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double NaN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_NaN17)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_MAX_VALUE18)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_MIN_VALUE19)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_SIZE20)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_TYPE21));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Double.staticClass = @__class;
            global::java.lang.Double.j4n_compareTo0 = @__env.GetMethodID(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Double.j4n_doubleToRawLongBits1 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
            global::java.lang.Double.j4n_doubleToLongBits2 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
            global::java.lang.Double.j4n_longBitsToDouble3 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
            global::java.lang.Double.j4n_compareTo4 = @__env.GetMethodID(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I");
            global::java.lang.Double.j4n_toHexString5 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
            global::java.lang.Double.j4n_toString6 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
            global::java.lang.Double.j4n_compare7 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "compare", "(DD)I");
            global::java.lang.Double.j4n_valueOf8 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
            global::java.lang.Double.j4n_valueOf9 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
            global::java.lang.Double.j4n_isNaN10 = @__env.GetMethodID(global::java.lang.Double.staticClass, "isNaN", "()Z");
            global::java.lang.Double.j4n_isNaN11 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
            global::java.lang.Double.j4n_isInfinite12 = @__env.GetMethodID(global::java.lang.Double.staticClass, "isInfinite", "()Z");
            global::java.lang.Double.j4n_isInfinite13 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
            global::java.lang.Double.j4n_parseDouble14 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
            global::java.lang.Double.j4n_POSITIVE_INFINITY15 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "POSITIVE_INFINITY", "D");
            global::java.lang.Double.j4n_NEGATIVE_INFINITY16 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "NEGATIVE_INFINITY", "D");
            global::java.lang.Double.j4n_NaN17 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "NaN", "D");
            global::java.lang.Double.j4n_MAX_VALUE18 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "MAX_VALUE", "D");
            global::java.lang.Double.j4n_MIN_VALUE19 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "MIN_VALUE", "D");
            global::java.lang.Double.j4n_SIZE20 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "SIZE", "I");
            global::java.lang.Double.j4n_TYPE21 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Double.j4n__ctorDouble22 = @__env.GetMethodID(global::java.lang.Double.staticClass, "<init>", "(D)V");
            global::java.lang.Double.j4n__ctorDouble23 = @__env.GetMethodID(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Double.j4n_compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)J")]
        public static long doubleToRawLongBits(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_doubleToRawLongBits1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)J")]
        public static long doubleToLongBits(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_doubleToLongBits2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)D")]
        public static double longBitsToDouble(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((double)(@__env.CallStaticDoubleMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_longBitsToDouble3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Double;)I")]
        public virtual int compareTo(global::java.lang.Double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Double.j4n_compareTo4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/String;")]
        public static global::java.lang.String toHexString(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_toHexString5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/String;")]
        public static global::java.lang.String toString(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_toString6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(DD)I")]
        public static int compare(double par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_compare7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Double;")]
        public static global::java.lang.Double valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Double>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_valueOf8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/Double;")]
        public static global::java.lang.Double valueOf(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Double>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_valueOf9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isNaN() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Double.j4n_isNaN10)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Z")]
        public static bool isNaN(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_isNaN11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isInfinite() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Double.j4n_isInfinite12)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Z")]
        public static bool isInfinite(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_isInfinite13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)D")]
        public static double parseDouble(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((double)(@__env.CallStaticDoubleMethod(global::java.lang.Double.staticClass, global::java.lang.Double.j4n_parseDouble14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Double(@__env);
            }
        }
    }
    #endregion
}
