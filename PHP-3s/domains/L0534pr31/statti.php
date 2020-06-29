<?php
session_start();
include_once "config.php";
include_once "function.php";

if (isset($_GET['oper']) && $_GET['oper']== 'del')
{
    if(isset($_GET['id']))
    {
        del_statti($_GET['id']);
    }
}

$data = get_statti();
?>

<?php
include_once "inc/header.php";
?>
<div id="content">
    <div id="main">
        <h1>Статьи</h1>
        <p class="blockquote text-right">
            <a href="edit_statti.php?oper=add&title=Добавить">Добавить</a>
        </p>
        <table class="table">
  <thead>
    <tr>
      <th scope="col">Id</th>
      <th scope="col">Заголовок</th>
      <th scope="col">Описание</th>
      <th scope="col">дата</th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($data as $item): ?>
    <tr>
      <th scope="row"><?=$item['id'] ?></th>
      <td><?=$item['title'] ?></td>
      <td><?=$item['mini_discr'] ?></td>
      <td><?=$item['date'] ?></td>
      <td>
        <a href="edit_statti.php?oper=edit&title=Добавить&id=<?=$item['id']?>"><button type="button" class="btn btn-success">Edit</button></a>
      </td>
      <td>
        <a href="statti.php?oper=del&id=<?=$item['id']?>"><button type="button" class="btn btn-danger">Dell</button>        
        </a>
      </td>

    </tr>
    <?php endforeach ?>
  
  </tbody>
</table>
<p class="blockquote text-right">
    <a href="edit_statti.php?oper=add&title=Добавить">Добавить</a>
</p>
    </div>
<?php
include_once "inc/sidebar.php";
?>


<?php
include_once "inc/footer.php"

?> 