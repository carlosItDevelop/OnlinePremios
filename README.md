## OnlinePremios

##### Projeto Online Prêmios | Visual Studio, Asp.Net Core 3.1

> Migrar para .NET5

> TaskList Processos:

- [ ] _**USUÁRIOS / CLIENTES:**_
  - [ ] Cadastro de Usuários;
    - [ ] Definir Papeis dos Usuários;
- [ ] _**SORTEIO:**_
  - [ ] Criar um Sorteio;
    - [ ] Definir Data inicial e Data do Sorteio;
    - [ ] Adicionar Fotos do Sorteio;
    - [ ] Adicionar Produtos na Galeria do Sorteio;
- [ ] _**COMPRA:**_
  - [ ] Iniciar uma Compra;
      - [ ] Adicionar Cliente;
      - [ ] Associar Sorteio(s);
      - [ ] Criar Checkout;
      - [ ] Alterações de Status;
      - [ ] Finalizar Compra;
- [ ] _**COTAS**_
    - [ ] 


---

> Prof. Preciso que faça o mapeamento da cota para o sorteio

---

_**IMPORTANTE**_
- [ ] Fazer mapeamento de cota para o sorteio, retirando o mapeamento de compra
- [ ] Quando cadastrar um sorteio ja fazer o cadastro das cotas em massa
    - [ ] Número sequencial iniciado do 0 ate a quantidade informada
    - [ ] Valor da cota
    - [ ] Status = Disponivel

---

> Quando fizer esse mapeamento eu ja vou cadastrar o primeiro sorteio
> para apresentar as cotas já cadastradas e vendendo

---

```CSharp
---
> Código funcional
@foreach (var item in Model)
               {
                    <div class="items col-xs-1 col-sm-1 col-md-1 col-lg-1" title="@Html.DisplayFor(modelItem => item.Compra.Cliente.Nome)">
                        <span class="info-block block-info clearfix">
                            <span data-toggle="buttons" class="btn-group bizmoduleselect">
                                <label class="btn btn-success">
                                    @Html.DisplayFor(modelItem => item.Numero)
                                    <span class="itemcontent">
                                        <input type="checkbox" name="var_id[]" autocomplete="off" value="">
                                    </span>
                                </label>
                            </span>
                        </span>
                    </div>

> Quero o codigo assim

@foreach (var item in Model)
               {
                    <div class="items col-xs-1 col-sm-1 col-md-1 col-lg-1" title="@Html.DisplayFor(modelItem => item.Compra.Cliente.Nome)">
                        <span class="info-block block-info clearfix">
                            <span data-toggle="buttons" class="btn-group bizmoduleselect">
                                @if @Html.DisplayFor(modelItem => item.Status=1)
                                {
                                <label class="btn btn-success">
                                    @Html.DisplayFor(modelItem => item.Numero)
                                    <span class="itemcontent">
                                        <input type="checkbox" name="var_id[]" autocomplete="off" value="">
                                    </span>
                                </label>
                                }
                                @if @Html.DisplayFor(modelItem => item.Status=2)
                                {
                                <label class="btn btn-warning">
                                    @Html.DisplayFor(modelItem => item.Numero)
                                    <span class="itemcontent">
                                        <input type="checkbox" name="var_id[]" autocomplete="off" value="">
                                    </span>
                                </label>
                                }
                                @if @Html.DisplayFor(modelItem => item.Status=3)
                                {
                                <label class="btn btn-danger">
                                    @Html.DisplayFor(modelItem => item.Numero)
                                    <span class="itemcontent">
                                        <input type="checkbox" name="var_id[]" autocomplete="off" value="">
                                    </span>
                                </label>
                                }

                            </span>
                        </span>
                    </div>
                    ```