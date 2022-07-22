using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1
{
    public class UserModuleClass_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput TIMEOUT;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> VIRTUAL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput TIMED_OUT;
        Crestron.Logos.SplusObjects.StringOutput TO_SCRIPTS_MODULES__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TO_MODULES__DOLLAR__;
        ushort IFLAG1 = 0;
        ushort A = 0;
        ushort B = 0;
        ushort C = 0;
        ushort INUMOUTPUTS = 0;
        ushort IPOINTER1 = 0;
        ushort IPOINTER2 = 0;
        CrestronString [] SBUFFERNAME;
        CrestronString STEMPNAME;
        CrestronString SCOMPORTMSG;
        private void FTIMEOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 66;
            CreateWait ( "WTIMEOUT" , 200 , WTIMEOUT_Callback ) ;
            
            }
            
        public void WTIMEOUT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 68;
            TIMED_OUT  .Value = (ushort) ( 1 ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 77;
            A = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 78;
            TO_MODULES__DOLLAR__ [ A]  .UpdateValue ( "Send Name\u000D"  ) ; 
            __context__.SourceCodeLine = 79;
            FTIMEOUT (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TIMEOUT_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        TIMED_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 85;
        Functions.Delay (  (int) ( 1 ) ) ; 
        __context__.SourceCodeLine = 86;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( A < INUMOUTPUTS ))  ) ) 
            { 
            __context__.SourceCodeLine = 88;
            A = (ushort) ( (A + 1) ) ; 
            __context__.SourceCodeLine = 89;
            TO_MODULES__DOLLAR__ [ A]  .UpdateValue ( "Send Name\u000D"  ) ; 
            __context__.SourceCodeLine = 90;
            FTIMEOUT (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIRTUAL_NAME__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 96;
        CancelWait ( "WTIMEOUT" ) ; 
        __context__.SourceCodeLine = 97;
        SBUFFERNAME [ A ]  .UpdateValue ( VIRTUAL_NAME__DOLLAR__ [ A ]  ) ; 
        __context__.SourceCodeLine = 98;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( A < INUMOUTPUTS ))  ) ) 
            { 
            __context__.SourceCodeLine = 100;
            A = (ushort) ( (A + 1) ) ; 
            __context__.SourceCodeLine = 101;
            TO_MODULES__DOLLAR__ [ A]  .UpdateValue ( "Send Name\u000D"  ) ; 
            __context__.SourceCodeLine = 102;
            FTIMEOUT (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSDEVICEMESSAGE (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 110;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( SCOMPORTMSG , (int)( 3 ) ) == "ran") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( SCOMPORTMSG , (int)( 3 ) ) == "run") )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 112;
        if ( Functions.TestForTrue  ( ( IsSignalDefined( TO_SCRIPTS_MODULES__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 114;
            TO_SCRIPTS_MODULES__DOLLAR__  .UpdateValue ( SCOMPORTMSG  ) ; 
            __context__.SourceCodeLine = 115;
            SCOMPORTMSG  .UpdateValue ( ""  ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 120;
        IPOINTER1 = (ushort) ( (Functions.Find( "\u0022" , SCOMPORTMSG ) + 1) ) ; 
        __context__.SourceCodeLine = 121;
        IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , SCOMPORTMSG , IPOINTER1 ) ) ; 
        __context__.SourceCodeLine = 123;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IPOINTER2 > IPOINTER1 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( SCOMPORTMSG , (int)( (IPOINTER2 - 1) ) ) == 92) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 125;
            IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , SCOMPORTMSG , (IPOINTER2 + 1) ) ) ; 
            __context__.SourceCodeLine = 123;
            } 
        
        __context__.SourceCodeLine = 128;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IPOINTER2 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( SCOMPORTMSG , (int)( IPOINTER2 ) , (int)( 3 ) ) == "\u0022\u0020\u0022") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 130;
            IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , SCOMPORTMSG , (IPOINTER2 + 3) ) ) ; 
            __context__.SourceCodeLine = 132;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IPOINTER2 > IPOINTER1 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( SCOMPORTMSG , (int)( (IPOINTER2 - 1) ) ) == 92) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , SCOMPORTMSG , (IPOINTER2 + 1) ) ) ; 
                __context__.SourceCodeLine = 132;
                } 
            
            } 
        
        __context__.SourceCodeLine = 138;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IPOINTER1 > 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IPOINTER2 > IPOINTER1 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 140;
            STEMPNAME  .UpdateValue ( Functions.Mid ( SCOMPORTMSG ,  (int) ( IPOINTER1 ) ,  (int) ( (IPOINTER2 - IPOINTER1) ) )  ) ; 
            __context__.SourceCodeLine = 142;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)INUMOUTPUTS; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( B  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (B  >= __FN_FORSTART_VAL__1) && (B  <= __FN_FOREND_VAL__1) ) : ( (B  <= __FN_FORSTART_VAL__1) && (B  >= __FN_FOREND_VAL__1) ) ; B  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 144;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SBUFFERNAME[ B ] == STEMPNAME))  ) ) 
                    { 
                    __context__.SourceCodeLine = 146;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( TO_MODULES__DOLLAR__[ B ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 148;
                        TO_MODULES__DOLLAR__ [ B]  .UpdateValue ( SCOMPORTMSG  ) ; 
                        __context__.SourceCodeLine = 149;
                        SCOMPORTMSG  .UpdateValue ( ""  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 151;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 142;
                } 
            
            } 
        
        else 
            { 
            } 
        
        } 
    
    
    }
    
object FROM_DEVICE__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 166;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 168;
            try 
                { 
                __context__.SourceCodeLine = 170;
                SCOMPORTMSG  .UpdateValue ( Functions.Gather ( "\u000D" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 171;
                PROCESSDEVICEMESSAGE (  __context__  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 175;
                Print( "3 Series issue with Comport message handeling\r\n") ; 
                
                }
                
                __context__.SourceCodeLine = 166;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 203;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 204;
        INUMOUTPUTS = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 205;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 100 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( C  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (C  >= __FN_FORSTART_VAL__1) && (C  <= __FN_FOREND_VAL__1) ) : ( (C  <= __FN_FORSTART_VAL__1) && (C  >= __FN_FOREND_VAL__1) ) ; C  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 207;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IsSignalDefined( TO_MODULES__DOLLAR__[ C ] ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 209;
                INUMOUTPUTS = (ushort) ( C ) ; 
                __context__.SourceCodeLine = 210;
                break ; 
                } 
            
            __context__.SourceCodeLine = 205;
            } 
        
        __context__.SourceCodeLine = 213;
        IFLAG1 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    STEMPNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SCOMPORTMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SBUFFERNAME  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        SBUFFERNAME [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( TIMEOUT__DigitalInput__, TIMEOUT );
    
    TIMED_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( TIMED_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( TIMED_OUT__DigitalOutput__, TIMED_OUT );
    
    VIRTUAL_NAME__DOLLAR__ = new InOutArray<StringInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        VIRTUAL_NAME__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( VIRTUAL_NAME__DOLLAR____AnalogSerialInput__ + i, VIRTUAL_NAME__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( VIRTUAL_NAME__DOLLAR____AnalogSerialInput__ + i, VIRTUAL_NAME__DOLLAR__[i+1] );
    }
    
    TO_SCRIPTS_MODULES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_SCRIPTS_MODULES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_SCRIPTS_MODULES__DOLLAR____AnalogSerialOutput__, TO_SCRIPTS_MODULES__DOLLAR__ );
    
    TO_MODULES__DOLLAR__ = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        TO_MODULES__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TO_MODULES__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TO_MODULES__DOLLAR____AnalogSerialOutput__ + i, TO_MODULES__DOLLAR__[i+1] );
    }
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 1024, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    WTIMEOUT_Callback = new WaitFunction( WTIMEOUT_CallbackFn );
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIMEOUT_OnPush_1, false ) );
    for( uint i = 0; i < 100; i++ )
        VIRTUAL_NAME__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( VIRTUAL_NAME__DOLLAR___OnChange_2, false ) );
        
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_3, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WTIMEOUT_Callback;


const uint INITIALIZE__DigitalInput__ = 0;
const uint TIMEOUT__DigitalInput__ = 1;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
const uint VIRTUAL_NAME__DOLLAR____AnalogSerialInput__ = 1;
const uint TIMED_OUT__DigitalOutput__ = 0;
const uint TO_SCRIPTS_MODULES__DOLLAR____AnalogSerialOutput__ = 0;
const uint TO_MODULES__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
