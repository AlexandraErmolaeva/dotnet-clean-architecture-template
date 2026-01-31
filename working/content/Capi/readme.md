# CLEAN ARCHITECTURE Capi Project

Микросервис, построенный по принципам чистой архитектуры.

## Структура проектов  
  
| Progect | Target | Dependencies |
| ------- | ------ | ------------ |
| **Capi.API** | Web api, точка входа | Application, Infrastructure |
| **Capi.Application** | Бизнес логика, use cases | Domain |  
| **Capi.Infrastructure** | Данные, внешние зависимости, репозитории | Application |  
| **Capi.Domain** | Доменные модели и сервисы | ❌ |  
