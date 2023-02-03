﻿using System;
using System.Collections.Generic;
using System.Text;
using Addons;
using EmbedIO.Sessions;
using OSCVRCWiz.Addons;
using OSCVRCWiz.Resources;
using AIChatbotWiz.Settings;
using OSCVRCWiz.TranslationAPIs;
using Settings;

namespace OSCVRCWiz
{
    public class SaveSettings
    {
        public static void SavingSettings()
        {
           
            //  UnregisterHotKey(this.Handle, 1);
            if (VoiceWizardWindow.MainFormGlobal.rjToggleButtonKeyRegion2.Checked == false)
            {
                Settings1.Default.yourRegion = "";
                Settings1.Default.yourKey = "";
            }
            // Settings1.Default.recognition = rjToggleButtonActivation.Checked;
            Settings1.Default.profanityFilterSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonProfan.Checked;
            Settings1.Default.logOrNotSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonLog.Checked;
            Settings1.Default.sendOSCSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonOSC.Checked;
            Settings1.Default.clearTTSWindowSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonClear.Checked;
            Settings1.Default.alwaysTopSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonOnTop2.Checked;
            Settings1.Default.wordsTranslateVRCSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonAsTranslated2.Checked;
            Settings1.Default.hideDelaySetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonHideDelay2.Checked;
            Settings1.Default.hideDelayValue = VoiceWizardWindow.MainFormGlobal.textBoxErase.Text.ToString();
            Settings1.Default.phraseListValue = VoiceWizardWindow.MainFormGlobal.richTextBox6.Text.ToString();
            Settings1.Default.phraseListBoolSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonPhraseList2.Checked;
            Settings1.Default.MicName = VoiceWizardWindow.MainFormGlobal.comboBoxInput.SelectedItem.ToString();
            Settings1.Default.SpeakerName = VoiceWizardWindow.MainFormGlobal.comboBoxOutput.SelectedItem.ToString();
            Settings1.Default.EmojiSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButton3.Checked;
            Settings1.Default.SpotifyOutputSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonCurrentSong.Checked;
            Settings1.Default.HRIntervalSetting = OSCListener.HRInternalValue.ToString();
            Settings1.Default.HRPortSetting = OSCListener.OSCReceiveport.ToString();
            Settings1.Default.BPMSpamSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButton2.Checked;
            Settings1.Default.voiceBoxSetting = VoiceWizardWindow.MainFormGlobal.comboBox2.SelectedIndex;
            Settings1.Default.styleBoxSetting = VoiceWizardWindow.MainFormGlobal.comboBox1.SelectedIndex;

            Settings1.Default.voiceLanguage = VoiceWizardWindow.MainFormGlobal.comboBox5.SelectedIndex;//voice language (make this save)
            Settings1.Default.langToBoxSetting = VoiceWizardWindow.MainFormGlobal.comboBox3.SelectedIndex;
            Settings1.Default.langSpokenSetting = VoiceWizardWindow.MainFormGlobal.comboBox4.SelectedIndex;



            Settings1.Default.pitchSetting = VoiceWizardWindow.MainFormGlobal.comboBoxPitch.SelectedIndex;
            Settings1.Default.volumeSetting = VoiceWizardWindow.MainFormGlobal.comboBoxVolume.SelectedIndex;
            Settings1.Default.rateSetting = VoiceWizardWindow.MainFormGlobal.comboBoxRate.SelectedIndex;
            Settings1.Default.STTTSContinuous = VoiceWizardWindow.MainFormGlobal.rjToggleButton4.Checked;
           // Settings1.Default.useBuiltInSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonLiteMode.Checked;
           // Settings1.Default.BuiltInVoiceSetting = VoiceWizardWindow.MainFormGlobal.comboBoxLite.SelectedIndex;
           // Settings1.Default.BuiltInOutputSetting = VoiceWizardWindow.MainFormGlobal.comboLiteOutput.SelectedItem.ToString();

            Settings1.Default.SpotifyPeriodicallySetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonPeriodic.Checked;
            Settings1.Default.SpotifySpamSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonSpotifySpam.Checked;
            Settings1.Default.SpotifyTimerIntervalSetting = SpotifyAddon.spotifyInterval;

           // Settings1.Default.AudioCancelSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonCancelAudio.Checked;
           // Settings1.Default.cultureInfoSetting = VoiceWizardWindow.MainFormGlobal.textBoxCultureInfo.Text.ToString();

            Settings1.Default.bannerSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButton5.Checked;

            Settings1.Default.SpotifyKey = VoiceWizardWindow.MainFormGlobal.textBoxSpotKey.Text.ToString();
            Settings1.Default.SpotifyLegacySetting = VoiceWizardWindow.MainFormGlobal.rjToggleSpotLegacy.Checked;

            Settings1.Default.SendVRCChatBoxSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonChatBox.Checked;
            Settings1.Default.ChatBoxKeyboardSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonShowKeyboard.Checked;

            Settings1.Default.minimizeToolBarSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButton6.Checked;
            Settings1.Default.GreenScreenSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonGreenScreen.Checked;
            Settings1.Default.SpotifyCustomSetting = VoiceWizardWindow.MainFormGlobal.textBoxCustomSpot.Text.ToString();


            Settings1.Default.VRCSoundNotifySetting = VoiceWizardWindow.MainFormGlobal.rjToggleSoundNotification.Checked;

            Settings1.Default.SystemTraySetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonSystemTray.Checked;
            Settings1.Default.playMediaSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButtonMedia.Checked;

            Settings1.Default.VRCUseDelay = VoiceWizardWindow.MainFormGlobal.rjToggleButtonChatBoxUseDelay.Checked;

           

            Settings1.Default.activateOSCStart = VoiceWizardWindow.MainFormGlobal.rjToggleButton8.Checked;

          //  Settings1.Default.independentSpotifyText = VoiceWizardWindow.MainFormGlobal.rjToggleButton9.Checked;


            //Settings1.Default.WebcaptionerSetting = VoiceWizardWindow.MainFormGlobal.rjToggleButton7.Checked;
           // Settings1.Default.saveUseAzure = VoiceWizardWindow.MainFormGlobal.rjToggleButtonWebCapAzure.Checked;
           // Settings1.Default.saveUseSystem = VoiceWizardWindow.MainFormGlobal.rjToggleButtonWebCapSystem.Checked;

            Settings1.Default.chatBoxSpotifyOnly = VoiceWizardWindow.MainFormGlobal.rjToggleButtonNoTTSKAT.Checked;
            Settings1.Default.chatBoxSpotifyOnly4VRC = VoiceWizardWindow.MainFormGlobal.rjToggleButtonNoTTSChat.Checked;

            Settings1.Default.SpotifyNoUseChatbox = VoiceWizardWindow.MainFormGlobal.rjToggleButtonSpotifyChatboxDisable.Checked;
            Settings1.Default.SpotifyNoUseKat = VoiceWizardWindow.MainFormGlobal.rjToggleButtonSpotifyKatDisable.Checked;

             Settings1.Default.heartrateOutput = VoiceWizardWindow.MainFormGlobal.rjToggleButton1.Checked;

            Settings1.Default.enableMedia = VoiceWizardWindow.MainFormGlobal.rjToggleButton10.Checked;

            Settings1.Default.ttsMode = VoiceWizardWindow.MainFormGlobal.comboBoxTTSMode.SelectedItem.ToString();

          //  Settings1.Default.approvedSource = VoiceWizardWindow.MainFormGlobal.richTextBox11.Text.ToString();
           
            Settings1.Default.StopOnPause = VoiceWizardWindow.MainFormGlobal.rjToggleButtonPlayPaused.Checked;

             Settings1.Default.voiceCommandList= VoiceCommands.voiceCommandsStored;

            string approvedString = "";
            foreach (object Item in VoiceWizardWindow.MainFormGlobal.checkedListBoxApproved.CheckedItems)
            {
                approvedString += Item.ToString()+",";
                
            }
            Settings1.Default.approvedSource = approvedString;


            Settings1.Default.saveDarkMode = VoiceWizardWindow.MainFormGlobal.rjToggleDarkMode.Checked;
            Settings1.Default.saveVoiceActStyle = VoiceWizardWindow.MainFormGlobal.rjToggleButtonStyle.Checked;
            Settings1.Default.STTModeSave = VoiceWizardWindow.MainFormGlobal.comboBoxSTT.SelectedItem.ToString();
            Settings1.Default.modelnamesave = VoiceWizardWindow.MainFormGlobal.modelTextBox.Text.ToString();

            Settings1.Default.deepLKeysave= DeepLTranslate.DeepLKey;

            Settings1.Default.OSCAddress= OSC.OSCAddress;
            Settings1.Default.OSCPort= OSC.OSCPort;

            Settings1.Default.saveToast= VoiceWizardWindow.MainFormGlobal.rjToggleDiscordToast.Checked;

            VoicePresets.presetsSave();
            Settings1.Default.presetSave = VoicePresets.presetsStored;

            WordReplacements.replacementSave();
            Settings1.Default.replaceSave = WordReplacements.wordReplacemntsStored;


            EmojiAddon.emojiReplacementsSave();
            Settings1.Default.emojiNewSave = EmojiAddon.emojiReplacemntsStored;

            Settings1.Default.discordParaSave= VoiceWizardWindow.MainFormGlobal.textBoxDiscordPara.Text.ToString();
            Settings1.Default.discordTimerSave = VoiceWizardWindow.MainFormGlobal.textBoxDiscTimer.Text.ToString();


            Settings1.Default.wordReplaceBeforeTTS = VoiceWizardWindow.MainFormGlobal.rjToggleReplaceBeforeTTS.Checked;

            Settings1.Default.hotketSave = VoiceWizardWindow.MainFormGlobal.rjToggleButton9.Checked;

            Settings1.Default.saveAutoRefreshKat= VoiceWizardWindow.MainFormGlobal.rjToggleButtonAutoRefreshKAT.Checked;




            /*
            emojiSettings.Default.emoji1 = VoiceWizardWindow.MainFormGlobal.EmojiBox1.Text.ToString();
            emojiSettings.Default.emoji2 = VoiceWizardWindow.MainFormGlobal.EmojiBox2.Text.ToString();
            emojiSettings.Default.emoji3 = VoiceWizardWindow.MainFormGlobal.EmojiBox3.Text.ToString();
            emojiSettings.Default.emoji4 = VoiceWizardWindow.MainFormGlobal.EmojiBox4.Text.ToString();
            emojiSettings.Default.emoji5 = VoiceWizardWindow.MainFormGlobal.EmojiBox5.Text.ToString();
            emojiSettings.Default.emoji6 = VoiceWizardWindow.MainFormGlobal.EmojiBox6.Text.ToString();
            emojiSettings.Default.emoji7 = VoiceWizardWindow.MainFormGlobal.EmojiBox7.Text.ToString();
            emojiSettings.Default.emoji8 = VoiceWizardWindow.MainFormGlobal.EmojiBox8.Text.ToString();
            emojiSettings.Default.emoji9 = VoiceWizardWindow.MainFormGlobal.EmojiBox9.Text.ToString();
            emojiSettings.Default.emoji10 = VoiceWizardWindow.MainFormGlobal.EmojiBox10.Text.ToString();
            emojiSettings.Default.emoji11 = VoiceWizardWindow.MainFormGlobal.EmojiBox11.Text.ToString();
            emojiSettings.Default.emoji12 = VoiceWizardWindow.MainFormGlobal.EmojiBox12.Text.ToString();
            emojiSettings.Default.emoji13 = VoiceWizardWindow.MainFormGlobal.EmojiBox13.Text.ToString();
            emojiSettings.Default.emoji14 = VoiceWizardWindow.MainFormGlobal.EmojiBox14.Text.ToString();
            emojiSettings.Default.emoji15 = VoiceWizardWindow.MainFormGlobal.EmojiBox15.Text.ToString();
            emojiSettings.Default.emoji16 = VoiceWizardWindow.MainFormGlobal.EmojiBox16.Text.ToString();
            emojiSettings.Default.emoji17 = VoiceWizardWindow.MainFormGlobal.EmojiBox17.Text.ToString();
            emojiSettings.Default.emoji18 = VoiceWizardWindow.MainFormGlobal.EmojiBox18.Text.ToString();
            emojiSettings.Default.emoji19 = VoiceWizardWindow.MainFormGlobal.EmojiBox19.Text.ToString();
            emojiSettings.Default.emoji20 = VoiceWizardWindow.MainFormGlobal.EmojiBox20.Text.ToString(); */



            Settings1.Default.Save();
            //emojiSettings.Default.Save();
            VoiceWizardWindow.MainFormGlobal.webView21.Dispose();
        }
    }
}
