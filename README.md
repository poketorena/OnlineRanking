# OnlineRanking

コミックマーケット94で販売したCTRL JOURNAL vol.9の「ASP.NET Core を使ってオンラインランキングを作る」のデータです。

## About

|#|プロジェクト名|概要|実行環境|
|----|----|----|----|
|1 | `GetAllScoreData`|サーバーからスコアをキーに降順でソートしたScoreDataのコレクションを取得し画面に表示するSiv3Dアプリケーション|実行には Siv3D August 2016 v2 が必要|
|2 | `GetScoreData`|サーバーから指定したidのScoreDataを取得し表示するSiv3Dアプリケーション|実行には Siv3D August 2016 v2 が必要|
|3 | `PostScoreData`|サーバーにScoreDataを送信するSiv3Dアプリケーション|実行には Siv3D August 2016 v2 が必要|
|4 | `RankingServer`|サーバー側のASP.NET Core MVCアプリケーション|実行には .NET Core 2.1 が必要|

## Usage

### Common

1. このリポジトリをクローン or ダウンロードする。
1. OnlineRanking.slnを開く。プロジェクトファイルをアップグレードするかどうか聞かれるがアップグレードしないこと。

### GetAllScoreData、GetScoreData、PostScoreData

1. ソリューションエクスプローラからプロジェクトを右クリックしてリビルドをクリックする。
1. ソリューションエクスプローラからプロジェクトを右クリックしてスタートアッププロジェクトに設定をクリックする。
1. F5等から実行する。

### RankingServer

1. ソリューションエクスプローラからプロジェクトを右クリックしてスタートアッププロジェクトに設定をクリックする。
1. F5等から実行する。

## Note

デフォルトでは作者の用意したサーバーにアクセスする設定のため、サーバーをMicrosoft Azureなどにデプロイしてランキングサーバーを運用する際はURL等を書き換える必要があるため注意すること。
