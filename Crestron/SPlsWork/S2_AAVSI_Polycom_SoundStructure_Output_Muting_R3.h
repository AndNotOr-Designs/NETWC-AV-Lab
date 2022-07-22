#ifndef __S2_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3_H__
#define __S2_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_SYSTEM_ISON_DIG_INPUT 0
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_UP_DIG_INPUT 1
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_DOWN_DIG_INPUT 2
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_MUTE_TOGGLE_DIG_INPUT 3


/*
* ANALOG_INPUT
*/
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_VALUE_IN_ANALOG_INPUT 0

#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_VIRTUAL_NAME$_STRING_INPUT 1
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_VIRTUAL_NAME$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __VIRTUAL_NAME$, __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_VIRTUAL_NAME$_STRING_MAX_LEN );

#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FROM_PROCESSOR$_BUFFER_INPUT 2
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FROM_PROCESSOR$_BUFFER_MAX_LEN 500
CREATE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __FROM_PROCESSOR$, __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FROM_PROCESSOR$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_DOWN_OK_DIG_OUTPUT 0
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_UP_OK_DIG_OUTPUT 1
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_MUTE_ON_FB_DIG_OUTPUT 2
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_MUTE_OFF_FB_DIG_OUTPUT 3
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_MUTE_ON_TRIG_DIG_OUTPUT 4
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_MUTE_OFF_TRIG_DIG_OUTPUT 5
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_POLL_DIG_OUTPUT 6


/*
* ANALOG_OUTPUT
*/
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_FADER_IN_ANALOG_OUTPUT 0

#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_VIRTUAL_NAME_OUT$_STRING_OUTPUT 1
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_TO_DEVICE$_STRING_OUTPUT 2


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_STEMP_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __STEMP, __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_STEMP_STRING_MAX_LEN );
#define __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_SNAME_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __SNAME, __S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3_SNAME_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __IFLAG1;
   unsigned short __IPOINTER1;
   unsigned short __IPOINTER2;
   unsigned short __IVALUE;
   unsigned short __IFADERSPAN;
   unsigned short __IFADERMULTIPLIER;
   unsigned short __IFADERMOD;
   unsigned short __IFADER;
   unsigned short __IMUTEONMIN;
   unsigned short __IMUTEVALUE;
   short __SIFADER;
   short __SIMAXFADER;
   short __SIMINFADER;
   short __SIFADERSTORED;
   DECLARE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __STEMP );
   DECLARE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __SNAME );
   DECLARE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __VIRTUAL_NAME$ );
   DECLARE_STRING_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3, __FROM_PROCESSOR$ );
};

START_NVRAM_VAR_STRUCT( S2_AAVSI_Polycom_SoundStructure_Output_Muting_R3 )
{
};



#endif //__S2_AAVSI_POLYCOM_SOUNDSTRUCTURE_OUTPUT_MUTING_R3_H__

