public class DynamicMethodUsingMSIL
{
    public static DynamicMethod MulBy2AndAdd1()
    {
        Type[] args = {typeof(int)};
    
        var m = new DynamicMethod("MulBy2AndAdd1", typeof(int), args, typeof(DynamicMethodUsingMSIL).Module);

        var generator = m.GetILGenerator();

        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldc_I4, 2);
        generator.Emit(OpCodes.Mul);
        generator.Emit(OpCodes.Ldc_I4, 1);
        generator.Emit(OpCodes.Add);
        generator.Emit(OpCodes.Ret);

        return m;
    }
}
