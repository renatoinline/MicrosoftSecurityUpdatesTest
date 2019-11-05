# MicrosoftSecurityUpdatesTest
Serviço para consumir Microsoft Security Updates

Projeto feito com .Net Core.

# WorkerServiceConsumer
O projeto WorkerServiceConsumer é o que roda em background e fica consumindo a API em busca de updates.
Executa separado do projeto Web.

# WebUI
Projeto MVC para exibir os dados sincronizados pelo Worker.

## Executar

Para executar é preciso alterar a connectionString para apontar para o banco correto.
Também é preciso executar o script SQL (está an raiz do repositório) para a criação da tabela.
