# Назначение
Skip authentication from .Web XAF

1) Create new class **CustomAuthentication** in .Web
2) Replace **this.securityStrategyComplex1.Authentication = this.customAuthentication1;** in .Web (WebApplication.cs)
3) Update .Web (Global.asax)
