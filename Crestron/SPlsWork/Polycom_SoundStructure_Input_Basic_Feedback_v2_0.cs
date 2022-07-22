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

namespace UserModule_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_0
{
    public class UserModuleClass_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput FADER_VALUE_IN;
        Crestron.Logos.SplusObjects.StringInput VIRTUAL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_PROCESSOR__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput FADER_DOWN_OK;
        Crestron.Logos.SplusObjects.DigitalOutput FADER_UP_OK;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_IN;
        Crestron.Logos.SplusObjects.DigitalOutput POLL;
        Crestron.Logos.SplusObjects.AnalogOutput FADER_IN;
        Crestron.Logos.SplusObjects.StringOutput VIRTUAL_NAME_OUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort ICURRENT = 0;
        ushort ISTART = 0;
        ushort IFLAG1 = 0;
        ushort IPOINTER1 = 0;
        ushort IPOINTER2 = 0;
        ushort IVALUE = 0;
        ushort IFADERSPAN = 0;
        ushort IFADERMULTIPLIER = 0;
        ushort IFADERMOD = 0;
        ushort IFADER = 0;
        short SIFADERVALUEIN = 0;
        short SIFADER = 0;
        short SIMAXFADER = 0;
        short SIMINFADER = 0;
        CrestronString STEMP;
        CrestronString SNAME;
        object FADER_VALUE_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 54;
                SIFADERVALUEIN = (short) ( FADER_VALUE_IN  .ShortValue ) ; 
                __context__.SourceCodeLine = 56;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SIFADERVALUEIN <= SIMAXFADER ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIFADERVALUEIN >= SIMINFADER ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    MakeString ( TO_DEVICE__DOLLAR__ , "set fader \u0022{0}\u0022 {1:d}\u000D", SNAME , (short)SIFADERVALUEIN) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VIRTUAL_NAME__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 64;
            Functions.ClearBuffer ( SNAME ) ; 
            __context__.SourceCodeLine = 66;
            ISTART = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 69;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( VIRTUAL_NAME__DOLLAR__ ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( ICURRENT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ICURRENT  >= __FN_FORSTART_VAL__1) && (ICURRENT  <= __FN_FOREND_VAL__1) ) : ( (ICURRENT  <= __FN_FORSTART_VAL__1) && (ICURRENT  >= __FN_FOREND_VAL__1) ) ; ICURRENT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 71;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VIRTUAL_NAME__DOLLAR__ , (int)( ICURRENT ) ) == 34))  ) ) 
                    { 
                    __context__.SourceCodeLine = 73;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ICURRENT > 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( VIRTUAL_NAME__DOLLAR__ , (int)( (ICURRENT - 1) ) ) != 92) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 75;
                        SNAME  .UpdateValue ( SNAME + Functions.Mid ( VIRTUAL_NAME__DOLLAR__ ,  (int) ( ISTART ) ,  (int) ( (ICURRENT - ISTART) ) ) + "\u005C\u0022"  ) ; 
                        __context__.SourceCodeLine = 76;
                        ISTART = (ushort) ( (ICURRENT + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 78;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURRENT == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 80;
                            SNAME  .UpdateValue ( "\u005C\u0022"  ) ; 
                            __context__.SourceCodeLine = 81;
                            ISTART = (ushort) ( (ICURRENT + 1) ) ; 
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 69;
                } 
            
            __context__.SourceCodeLine = 87;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTART < ICURRENT ))  ) ) 
                { 
                __context__.SourceCodeLine = 89;
                SNAME  .UpdateValue ( SNAME + Functions.Mid ( VIRTUAL_NAME__DOLLAR__ ,  (int) ( ISTART ) ,  (int) ( ((ICURRENT - ISTART) + 1) ) )  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FROM_PROCESSOR__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 95;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 97;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 98;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROM_PROCESSOR__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 100;
                STEMP  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_PROCESSOR__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 103;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SNAME , STEMP ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 106;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "val fader min" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 108;
                        IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                        __context__.SourceCodeLine = 109;
                        IPOINTER1 = (ushort) ( (Functions.Length( SNAME ) + IPOINTER1) ) ; 
                        __context__.SourceCodeLine = 110;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-" , STEMP , IPOINTER1 ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 112;
                            SIMINFADER = (short) ( (0 - Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) )) ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 116;
                            SIMINFADER = (short) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 118;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER > SIMINFADER ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 120;
                            FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 124;
                            FADER_DOWN_OK  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 126;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER < SIMAXFADER ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 128;
                            FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 132;
                            FADER_UP_OK  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 134;
                        IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
                        __context__.SourceCodeLine = 135;
                        IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
                        __context__.SourceCodeLine = 136;
                        IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
                        __context__.SourceCodeLine = 137;
                        IFADER = (ushort) ( (((SIFADER - SIMINFADER) * IFADERMULTIPLIER) + (((SIFADER - SIMINFADER) * IFADERMOD) / IFADERSPAN)) ) ; 
                        __context__.SourceCodeLine = 138;
                        FADER_IN  .Value = (ushort) ( IFADER ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 140;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "val fader max" , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 142;
                            IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                            __context__.SourceCodeLine = 143;
                            IPOINTER1 = (ushort) ( (Functions.Length( SNAME ) + IPOINTER1) ) ; 
                            __context__.SourceCodeLine = 144;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-" , STEMP , IPOINTER1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 146;
                                SIMAXFADER = (short) ( (0 - Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) )) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 150;
                                SIMAXFADER = (short) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 152;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER > SIMINFADER ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 154;
                                FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 158;
                                FADER_DOWN_OK  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 160;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER < SIMAXFADER ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 162;
                                FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 166;
                                FADER_UP_OK  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 168;
                            IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
                            __context__.SourceCodeLine = 169;
                            IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
                            __context__.SourceCodeLine = 170;
                            IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
                            __context__.SourceCodeLine = 171;
                            IFADER = (ushort) ( (((SIFADER - SIMINFADER) * IFADERMULTIPLIER) + (((SIFADER - SIMINFADER) * IFADERMOD) / IFADERSPAN)) ) ; 
                            __context__.SourceCodeLine = 172;
                            FADER_IN  .Value = (ushort) ( IFADER ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 174;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "val fader" , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 176;
                                IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                                __context__.SourceCodeLine = 177;
                                IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , STEMP , (IPOINTER1 + 1) ) ) ; 
                                __context__.SourceCodeLine = 178;
                                IPOINTER1 = (ushort) ( Functions.Find( "\u0020" , STEMP , (IPOINTER2 + 1) ) ) ; 
                                __context__.SourceCodeLine = 179;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-" , STEMP , IPOINTER2 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 181;
                                    SIFADER = (short) ( (0 - Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) )) ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 185;
                                    SIFADER = (short) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 187;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER > SIMINFADER ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 189;
                                    FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 193;
                                    FADER_DOWN_OK  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 195;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER < SIMAXFADER ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 197;
                                    FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 201;
                                    FADER_UP_OK  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 203;
                                IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
                                __context__.SourceCodeLine = 204;
                                IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
                                __context__.SourceCodeLine = 205;
                                IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
                                __context__.SourceCodeLine = 206;
                                IFADER = (ushort) ( (((SIFADER - SIMINFADER) * IFADERMULTIPLIER) + (((SIFADER - SIMINFADER) * IFADERMOD) / IFADERSPAN)) ) ; 
                                __context__.SourceCodeLine = 207;
                                FADER_IN  .Value = (ushort) ( IFADER ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 209;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "val mute" , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 211;
                                    IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 212;
                                    IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , STEMP , (IPOINTER1 + 1) ) ) ; 
                                    __context__.SourceCodeLine = 213;
                                    IPOINTER1 = (ushort) ( Functions.Find( "\u0020" , STEMP , (IPOINTER2 + 1) ) ) ; 
                                    __context__.SourceCodeLine = 214;
                                    IVALUE = (ushort) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 215;
                                    MUTE_IN  .Value = (ushort) ( IVALUE ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 219;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name\u000D" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 221;
                        VIRTUAL_NAME_OUT__DOLLAR__  .UpdateValue ( SNAME  ) ; 
                        __context__.SourceCodeLine = 222;
                        POLL  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 223;
                        POLL  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 98;
                } 
            
            __context__.SourceCodeLine = 226;
            IFLAG1 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 236;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 237;
        SIMINFADER = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
        __context__.SourceCodeLine = 238;
        SIMAXFADER = (short) ( 20 ) ; 
        __context__.SourceCodeLine = 239;
        IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
        __context__.SourceCodeLine = 240;
        IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
        __context__.SourceCodeLine = 241;
        IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
        __context__.SourceCodeLine = 242;
        FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 243;
        FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    FADER_DOWN_OK = new Crestron.Logos.SplusObjects.DigitalOutput( FADER_DOWN_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( FADER_DOWN_OK__DigitalOutput__, FADER_DOWN_OK );
    
    FADER_UP_OK = new Crestron.Logos.SplusObjects.DigitalOutput( FADER_UP_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( FADER_UP_OK__DigitalOutput__, FADER_UP_OK );
    
    MUTE_IN = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_IN__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_IN__DigitalOutput__, MUTE_IN );
    
    POLL = new Crestron.Logos.SplusObjects.DigitalOutput( POLL__DigitalOutput__, this );
    m_DigitalOutputList.Add( POLL__DigitalOutput__, POLL );
    
    FADER_VALUE_IN = new Crestron.Logos.SplusObjects.AnalogInput( FADER_VALUE_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FADER_VALUE_IN__AnalogSerialInput__, FADER_VALUE_IN );
    
    FADER_IN = new Crestron.Logos.SplusObjects.AnalogOutput( FADER_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FADER_IN__AnalogSerialOutput__, FADER_IN );
    
    VIRTUAL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( VIRTUAL_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( VIRTUAL_NAME__DOLLAR____AnalogSerialInput__, VIRTUAL_NAME__DOLLAR__ );
    
    VIRTUAL_NAME_OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VIRTUAL_NAME_OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VIRTUAL_NAME_OUT__DOLLAR____AnalogSerialOutput__, VIRTUAL_NAME_OUT__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, 500, this );
    m_StringInputList.Add( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, FROM_PROCESSOR__DOLLAR__ );
    
    
    FADER_VALUE_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( FADER_VALUE_IN_OnChange_0, false ) );
    VIRTUAL_NAME__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VIRTUAL_NAME__DOLLAR___OnChange_1, false ) );
    FROM_PROCESSOR__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_PROCESSOR__DOLLAR___OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint FADER_VALUE_IN__AnalogSerialInput__ = 0;
const uint VIRTUAL_NAME__DOLLAR____AnalogSerialInput__ = 1;
const uint FROM_PROCESSOR__DOLLAR____AnalogSerialInput__ = 2;
const uint FADER_DOWN_OK__DigitalOutput__ = 0;
const uint FADER_UP_OK__DigitalOutput__ = 1;
const uint MUTE_IN__DigitalOutput__ = 2;
const uint POLL__DigitalOutput__ = 3;
const uint FADER_IN__AnalogSerialOutput__ = 0;
const uint VIRTUAL_NAME_OUT__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 2;

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
