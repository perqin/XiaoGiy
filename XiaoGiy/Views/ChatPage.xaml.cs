using System;
using System.Collections.Generic;
using Windows.Data.Json;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;
using XiaoGiy.Models;
using XiaoGiy.Utils;

namespace XiaoGiy.Views {
    public sealed partial class ChatPage : Page {
        public ChatPage() {
            InitializeComponent();
        }

        public async void SendMessage() {
            // Prepare
            string msg = SendTextBox.Text;
            string id = App.MeVM.Me.Id;
            if (msg == "") return;
            App.ChatVM.ChatMessages.Add(new MessageModel() {
                Content = msg,
                Who = C.ME
            });
            SendTextBox.Text = "";
            // Send request
            HttpClient httpClient = new HttpClient();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("key", ApiKey.Key);
            parameters.Add("info", msg);
            parameters.Add("userid", id);
            HttpRequestMessage request = new HttpRequestMessage() {
                Content = new HttpFormUrlEncodedContent(parameters),
                Method = HttpMethod.Post,
                RequestUri = new Uri(C.API_URI, UriKind.Absolute)
            };
            HttpResponseMessage response = await httpClient.SendRequestAsync(request);
            if (response.IsSuccessStatusCode) {
                HttpStreamContent responseContent = (HttpStreamContent)response.Content;
                if (responseContent != null) {
                    JsonObject resJson = JsonObject.Parse(responseContent.ToString());
                    int code = (int)resJson["code"].GetNumber();
                    string text = resJson["text"].GetString();
                    App.ChatVM.ChatMessages.Add(new MessageModel() {
                        Type = code,
                        Content = text,
                        Who = C.GIY
                    });
                    //switch (code) {
                    //    case C.MSG_TYPE_TEXT
                    //}
                    //try {
                    //} catch (JsonError e) {

                    //}
                }
            } else {
                //TODO: Alert
            }
        }

        private void SendButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            SendMessage();
        }
    }
}
