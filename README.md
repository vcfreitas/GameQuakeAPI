# Quake log parser

O projeto constitui em uma API que retorna um parser do arquivo de logo do jogo quake 3 arena.

O arquivo games.log é gerado pelo servidor de quake 3 arena. Ele registra todas as informações dos jogos, quando um jogo começa, quando termina, quem matou quem, quem morreu pq caiu no vazio, quem morreu machucado, entre outros.

O parser deve ser capaz de ler o arquivo, agrupar os dados de cada jogo, e em cada jogo deve coletar as informações de morte.

Ao aplicar o parser sobre o arquivo de log, resultará em um json, como apresentado abaixo:

[
  {
    "gameId": 1,
    "total_kills": 0,
    "players": [
      {
        "playerId": 2,
        "playerName": "Isgalamido"
      }
    ],
    "kills": [
      {
        "playerId": 2,
        "playerName": "Isgalamido",
        "playerDeaths": 0
      }
    ]
  },
  {
    "gameId": 2,
    "total_kills": 11,
    "players": [
      {
        "playerId": 2,
        "playerName": "Isgalamido"
      },
      {
        "playerId": 3,
        "playerName": "Mocinha"
      }
    ],
    "kills": [
      {
        "playerId": 2,
        "playerName": "Isgalamido",
        "playerDeaths": -6
      },
      {
        "playerId": 3,
        "playerName": "Mocinha",
        "playerDeaths": 1
      }
    ]
  }
]

#Listar games

GET /api/game/quakelog