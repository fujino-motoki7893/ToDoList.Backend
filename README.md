# ToDoList.Backend

ToDoList のバックエンドリポジトリです。

1. dotnet フレームワークの dotnet8 をインストールする。
    - [ここ](https://dotnet.microsoft.com/ja-jp/download/dotnet/8.0)からインストールしてください(mac windows それぞれ方法が違うので注意)
2. `cd Digital.Emc.Backend` で project がある階層に移動します。
3. `dotnet restore` をします。


## ローカルで立ち上げるcommand
`dotnet run --project ToDoList`

# DB を立ち上げる方法
- `cd .\ToDoList\`
- `docker build -t to-do-list-backend .`
- `docker-compose up -d`

それぞれのDBツールでアクセスする
