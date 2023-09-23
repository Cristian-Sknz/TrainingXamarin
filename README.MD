<div align="center">
    <img width="300" src=".github/xamarin.png"/>
</div>

## Projeto
Este projeto mostra o meu progresso no aprendizado de duas novas tecnologias, C# e Xamarin.Forms. E para praticar resolvi clonar uma [UI Redesign inspirada no Spotify](https://www.figma.com/community/file/1177133218748034862) que encontrei no Figma.

<div align="center">
    <img height="512" src=".github/preview.png"/>
</div>

Não foram implementadas todas as telas que estão no design do Figma, pretendo implementar em breve. No entanto, na unica tela implementada foi possível utilizar vários recursos disponíveis no Xamarin.

#### Adaptação na nova linguagem de programação
O processo de adaptação na linguagem C# está sendo relativamente bem simples, devida a muitas semelhanças com Java, o processo de aprendizado se torna facil. Estou precisando aprender apenas as bibliotecas nativas da linguagem, e estou seguindo um pequeno guia 'C# for Java Developers'. 

Outra coisa que me aventurei em aprender foram as features diferentes do Java que por serem parecidas ou iguais as features do Kotlin como:

- Inline Functions (ou Inline Methods)
- Delegate Properties (`{ get; set; }`)
- String Interpolation
- Lambda
- Cast (usando `as`)
- Null Safety
- Async & Await (Com o conceito parecido com as  corrotinas do Kotlin)
- Entre outras coisas.

### Do Android ao Xamarin
Para aprender sobre Xamarin.Forms estou usando a [documentação oficial](https://learn.microsoft.com/en-us/xamarin/) e usando o StackOverflow para algumas questões que surgem durante o aprendizado. Antes de começar a implementar a interface e lógica de negócio apenas no Xamarin.Forms, decidi começar pelo Xamarin.Android. 

O Xamarin.Android implementa a mesma especificação que existe no desenvolvimento nativo com Kotlin/Java, ou seja, os códigos que você escreve em Kotlin/Java podem funcionar no Xamarin com algumas adaptações. Um exemplo disso são as Activities que são identicas:
```kotlin
class MainActivity: AppCompatActivity {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }
}
```

```csharp
public class MainActivity: AppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState) 
    {
        base.OnCreate(savedInstanceState);
        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
        SetContentView(Resource.Layout.activity_main);
    }    
}
```
Então com a mesma interface do Android nativo, a migração para o Xamarin.Android foi tranquila. A criação de layouts por meio do XML do Android permaneceu inalterada, assim como o uso de drawables e outros recursos.

Graças à existência de uma ponte para a JVM através do JNI (Java Native Interface), diversas classes Java foram adaptadas para serem usadas no Xamarin. No entanto, é importante mencionar que existe algumas limitações nas adaptações que ainda preciso explorar, como a ausência de suporte a genéricos em classes Java, por exemplo (como o ArrayList<T>).

Além disso, algumas das bibliotecas mais populares do Android também estão disponíveis, mas eu não explorei todas elas. Até o momento, analisei apenas algumas delas, incluindo a biblioteca para ViewModel e navegação.

#### Xamarin.Forms
O Xamarin.Forms permite que você crie aplicativos para diversos disposivos como Android, IOS e Windows usando a mesma codebase com código compartilhado. Você pode escrever a mesma interface e logica de negócio uma vez para todos os dispositivos.

E caso precise usar recursos que são nativos de cada OS, é possível criar interfaces que podem ser implementadas de acordo com cada sistema operacional, o Xamarin se encarrega de escolher qual interface é adequada para cada OS.

Neste projeto, mesmo sendo dados mockados implementei o padrão MVVM e aprendi os recursos basicos para a construção das interfaces. Outras coisas que explorei no Xamarin foram:
- Controls (Criar componentes sem XAML)
- IValueConverter
- Application Resources
- Dependency Service
- CollectionView
- BindableLayout
- RelativeLayout
- ObservableCollection
- Binding Context
- Property Binding
- Navigation
