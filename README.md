# WebAPI_HTMLClient_Sampler
クライアントにプレーンなHTML、Web API2、バックエンドにEF6を使用したサンプル

## コントローラの作成（スキャフォールディング）
コントローラを作成する場合、スキャフォールディング機能を活用するとCRUDを自動生成できる。  
方法は ...  
1、Controllersを右クリック　→　追加　→　新規スキャフォールディングアイテムを追加  
2、Web API 2 Controller with actions, using Entity Framework を選択して追加ボタンを押下  
3、コントローラが扱う Model Class をプルダウンより選択（参照を通しておくこと）  
4、同じく、コントローラが扱う、Data context class をプルダウンより選択  
5、Use async controller actions にチェック  
6、Controller name を設定  
7、Addボタンを押下  
以上でCRUDを持ったControllerクラスが自動生成される。  
