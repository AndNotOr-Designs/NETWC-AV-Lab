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

namespace UserModule_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3
{
    public class UserModuleClass_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput FADER_VALUE_IN;
        Crestron.Logos.SplusObjects.StringInput VIRTUAL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_PROCESSOR__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput SYSTEM_ISON;
        Crestron.Logos.SplusObjects.DigitalInput FADER_UP;
        Crestron.Logos.SplusObjects.DigitalInput FADER_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput FADER_DOWN_OK;
        Crestron.Logos.SplusObjects.DigitalOutput FADER_UP_OK;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_ON_TRIG;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_OFF_TRIG;
        Crestron.Logos.SplusObjects.DigitalOutput POLL;
        Crestron.Logos.SplusObjects.AnalogOutput FADER_IN;
        Crestron.Logos.SplusObjects.StringOutput VIRTUAL_NAME_OUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IFLAG1 = 0;
        ushort IPOINTER1 = 0;
        ushort IPOINTER2 = 0;
        ushort IVALUE = 0;
        ushort IFADERSPAN = 0;
        ushort IFADERMULTIPLIER = 0;
        ushort IFADERMOD = 0;
        ushort IFADER = 0;
        ushort IMUTEONMIN = 0;
        ushort IMUTEVALUE = 0;
        short SIFADER = 0;
        short SIMAXFADER = 0;
        short SIMINFADER = 0;
        short SIFADERSTORED = 0;
        CrestronString STEMP;
        CrestronString SNAME;
        object FADER_VALUE_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 77;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( FADER_VALUE_IN  .UshortValue <= SIMAXFADER ) ) && Functions.TestForTrue ( Functions.BoolToInt ( FADER_VALUE_IN  .UshortValue >= SIMINFADER ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 79;
                    MakeString ( TO_DEVICE__DOLLAR__ , "set fader \u0022{0}\u0022 {1:d}\u000D", SNAME , (short)FADER_VALUE_IN  .UshortValue) ; 
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
            
            __context__.SourceCodeLine = 85;
            SNAME  .UpdateValue ( VIRTUAL_NAME__DOLLAR__  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 90;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 92;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 93;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROM_PROCESSOR__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                STEMP  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_PROCESSOR__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name\u000D" , STEMP ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 98;
                    VIRTUAL_NAME_OUT__DOLLAR__  .UpdateValue ( SNAME  ) ; 
                    __context__.SourceCodeLine = 99;
                    POLL  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 100;
                    POLL  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 103;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( SNAME , STEMP ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "val" , Functions.Lower( STEMP ) ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "fader min" , Functions.Lower( STEMP ) ) > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 105;
                        IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                        __context__.SourceCodeLine = 106;
                        IPOINTER1 = (ushort) ( (Functions.Length( SNAME ) + IPOINTER1) ) ; 
                        __context__.SourceCodeLine = 107;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-" , STEMP , IPOINTER1 ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 109;
                            SIMINFADER = (short) ( (0 - Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) )) ) ; 
                            __context__.SourceCodeLine = 110;
                            Print( "siMinFader = {0:d} Line 105\r\n", (short)SIMINFADER) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 114;
                            SIMINFADER = (short) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 115;
                            Print( "siMinFader = {0:d} Line 110\r\n", (short)SIMINFADER) ; 
                            } 
                        
                        __context__.SourceCodeLine = 117;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER > SIMINFADER ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 119;
                            FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 123;
                            FADER_DOWN_OK  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 125;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER < SIMAXFADER ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 127;
                            FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 131;
                            FADER_UP_OK  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 133;
                        IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
                        __context__.SourceCodeLine = 134;
                        IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
                        __context__.SourceCodeLine = 135;
                        IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
                        __context__.SourceCodeLine = 136;
                        IFADER = (ushort) ( (((SIFADER - SIMINFADER) * IFADERMULTIPLIER) + (((SIFADER - SIMINFADER) * IFADERMOD) / IFADERSPAN)) ) ; 
                        __context__.SourceCodeLine = 137;
                        FADER_IN  .Value = (ushort) ( IFADER ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 140;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( SNAME , STEMP ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "val" , Functions.Lower( STEMP ) ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "fader max" , Functions.Lower( STEMP ) ) > 0 ) )) ))  ) ) 
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
                            __context__.SourceCodeLine = 175;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( SNAME , STEMP ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "val" , Functions.Lower( STEMP ) ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "fader" , Functions.Lower( STEMP ) ) > 0 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 177;
                                IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                                __context__.SourceCodeLine = 178;
                                IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , STEMP , (IPOINTER1 + 1) ) ) ; 
                                __context__.SourceCodeLine = 179;
                                IPOINTER1 = (ushort) ( Functions.Find( "\u0020" , STEMP , (IPOINTER2 + 1) ) ) ; 
                                __context__.SourceCodeLine = 181;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-" , STEMP , IPOINTER2 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 183;
                                    SIFADER = (short) ( (0 - Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) )) ) ; 
                                    __context__.SourceCodeLine = 184;
                                    Print( "siFader (negative) = {0:d} Line 179\r\n", (short)SIFADER) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 189;
                                    SIFADER = (short) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 190;
                                    Print( "siFader (positive) = {0:d} Line 185\r\n", (short)SIFADER) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 192;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER > SIMINFADER ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 194;
                                    FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 198;
                                    FADER_DOWN_OK  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 200;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIFADER < SIMAXFADER ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 202;
                                    FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 206;
                                    FADER_UP_OK  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 212;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIFADER == SIMINFADER))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 214;
                                    Functions.Pulse ( 10, MUTE_ON_TRIG ) ; 
                                    __context__.SourceCodeLine = 215;
                                    Print( "Mute on Min triggered line 210\r\n") ; 
                                    } 
                                
                                __context__.SourceCodeLine = 219;
                                IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
                                __context__.SourceCodeLine = 220;
                                IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
                                __context__.SourceCodeLine = 221;
                                IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
                                __context__.SourceCodeLine = 222;
                                IFADER = (ushort) ( (((SIFADER - SIMINFADER) * IFADERMULTIPLIER) + (((SIFADER - SIMINFADER) * IFADERMOD) / IFADERSPAN)) ) ; 
                                __context__.SourceCodeLine = 223;
                                FADER_IN  .Value = (ushort) ( IFADER ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 225;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( SNAME , STEMP ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "val" , Functions.Lower( STEMP ) ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "mute" , Functions.Lower( STEMP ) ) > 0 ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 227;
                                    IPOINTER1 = (ushort) ( Functions.Find( SNAME , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 228;
                                    IPOINTER2 = (ushort) ( Functions.Find( "\u0022" , STEMP , (IPOINTER1 + 1) ) ) ; 
                                    __context__.SourceCodeLine = 229;
                                    IPOINTER1 = (ushort) ( Functions.Find( "\u0020" , STEMP , (IPOINTER2 + 1) ) ) ; 
                                    __context__.SourceCodeLine = 230;
                                    IVALUE = (ushort) ( Functions.Atoi( Functions.Right( STEMP , (int)( (Functions.Length( STEMP ) - IPOINTER1) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 232;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IVALUE == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 234;
                                        MUTE_ON_FB  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 235;
                                        MUTE_OFF_FB  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 236;
                                        IMUTEVALUE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 237;
                                        Print( "Mute Value = {0:d} Line 232\r\n", (short)IMUTEVALUE) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 239;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IVALUE == 1))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 241;
                                        MUTE_ON_FB  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 242;
                                        MUTE_OFF_FB  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 243;
                                        IMUTEVALUE = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 93;
                } 
            
            __context__.SourceCodeLine = 251;
            IFLAG1 = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FADER_UP_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 260;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMUTEVALUE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 262;
            Functions.Pulse ( 10, MUTE_OFF_TRIG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FADER_UP_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 270;
        SIFADERSTORED = (short) ( SIFADER ) ; 
        __context__.SourceCodeLine = 271;
        Print( "siFaderStored = {0:d} Line 264\r\n", (short)SIFADERSTORED) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FADER_DOWN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FADER_DOWN_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 280;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIFADER == SIMINFADER))  ) ) 
            { 
            __context__.SourceCodeLine = 284;
            SIFADERSTORED = (short) ( SIFADER ) ; 
            __context__.SourceCodeLine = 285;
            Print( "sifader = {0:d} Line 278", (short)SIFADER) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 289;
            SIFADERSTORED = (short) ( SIFADER ) ; 
            __context__.SourceCodeLine = 290;
            Print( "sifader = {0:d} Line 283", (short)SIFADER) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_TOGGLE_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 296;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMUTEVALUE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 299;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIFADERSTORED == SIMINFADER))  ) ) 
                { 
                __context__.SourceCodeLine = 301;
                SIFADER = (short) ( (SIFADERSTORED + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 305;
                SIFADER = (short) ( SIFADERSTORED ) ; 
                } 
            
            __context__.SourceCodeLine = 307;
            MakeString ( TO_DEVICE__DOLLAR__ , "set fader \u0022{0}\u0022 {1:d}\u000D", SNAME , (short)SIFADER) ; 
            __context__.SourceCodeLine = 308;
            Print( "sifader = {0:d} Line 301", (short)SIFADER) ; 
            __context__.SourceCodeLine = 309;
            MakeString ( TO_DEVICE__DOLLAR__ , "set mute \u0022{0}\u0022 0\u000D", SNAME ) ; 
            } 
        
        __context__.SourceCodeLine = 311;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMUTEVALUE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 313;
            SIFADER = (short) ( SIMINFADER ) ; 
            __context__.SourceCodeLine = 314;
            MakeString ( TO_DEVICE__DOLLAR__ , "set fader \u0022{0}\u0022 {1:d}\u000D", SNAME , (short)SIFADER) ; 
            __context__.SourceCodeLine = 315;
            Print( "sifader = {0:d} Line 307", (short)SIFADER) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYSTEM_ISON_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 321;
        SIFADERSTORED = (short) ( SIFADER ) ; 
        
        
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
        
        __context__.SourceCodeLine = 334;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 335;
        SIMINFADER = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
        __context__.SourceCodeLine = 336;
        SIMAXFADER = (short) ( 20 ) ; 
        __context__.SourceCodeLine = 337;
        IFADERSPAN = (ushort) ( (SIMAXFADER - SIMINFADER) ) ; 
        __context__.SourceCodeLine = 338;
        IFADERMULTIPLIER = (ushort) ( (65535 / IFADERSPAN) ) ; 
        __context__.SourceCodeLine = 339;
        IFADERMOD = (ushort) ( Mod( 65535 , IFADERSPAN ) ) ; 
        __context__.SourceCodeLine = 340;
        FADER_DOWN_OK  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 341;
        FADER_UP_OK  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 342;
        IMUTEONMIN = (ushort) ( 0 ) ; 
        
        
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
    
    SYSTEM_ISON = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEM_ISON__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEM_ISON__DigitalInput__, SYSTEM_ISON );
    
    FADER_UP = new Crestron.Logos.SplusObjects.DigitalInput( FADER_UP__DigitalInput__, this );
    m_DigitalInputList.Add( FADER_UP__DigitalInput__, FADER_UP );
    
    FADER_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( FADER_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( FADER_DOWN__DigitalInput__, FADER_DOWN );
    
    MUTE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_TOGGLE__DigitalInput__, MUTE_TOGGLE );
    
    FADER_DOWN_OK = new Crestron.Logos.SplusObjects.DigitalOutput( FADER_DOWN_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( FADER_DOWN_OK__DigitalOutput__, FADER_DOWN_OK );
    
    FADER_UP_OK = new Crestron.Logos.SplusObjects.DigitalOutput( FADER_UP_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( FADER_UP_OK__DigitalOutput__, FADER_UP_OK );
    
    MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_ON_FB__DigitalOutput__, MUTE_ON_FB );
    
    MUTE_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_OFF_FB__DigitalOutput__, MUTE_OFF_FB );
    
    MUTE_ON_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_ON_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_ON_TRIG__DigitalOutput__, MUTE_ON_TRIG );
    
    MUTE_OFF_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_OFF_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_OFF_TRIG__DigitalOutput__, MUTE_OFF_TRIG );
    
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
    FADER_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FADER_UP_OnPush_3, false ) );
    FADER_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FADER_UP_OnRelease_4, false ) );
    FADER_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FADER_DOWN_OnPush_5, false ) );
    FADER_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FADER_DOWN_OnRelease_6, false ) );
    MUTE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_TOGGLE_OnPush_7, false ) );
    SYSTEM_ISON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEM_ISON_OnPush_8, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint FADER_VALUE_IN__AnalogSerialInput__ = 0;
const uint VIRTUAL_NAME__DOLLAR____AnalogSerialInput__ = 1;
const uint FROM_PROCESSOR__DOLLAR____AnalogSerialInput__ = 2;
const uint SYSTEM_ISON__DigitalInput__ = 0;
const uint FADER_UP__DigitalInput__ = 1;
const uint FADER_DOWN__DigitalInput__ = 2;
const uint MUTE_TOGGLE__DigitalInput__ = 3;
const uint FADER_DOWN_OK__DigitalOutput__ = 0;
const uint FADER_UP_OK__DigitalOutput__ = 1;
const uint MUTE_ON_FB__DigitalOutput__ = 2;
const uint MUTE_OFF_FB__DigitalOutput__ = 3;
const uint MUTE_ON_TRIG__DigitalOutput__ = 4;
const uint MUTE_OFF_TRIG__DigitalOutput__ = 5;
const uint POLL__DigitalOutput__ = 6;
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
