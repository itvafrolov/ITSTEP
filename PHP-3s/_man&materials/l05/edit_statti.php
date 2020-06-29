<?php
require_once("config.php");
require_once("functions.php");
?>

<?php include_once "inc/header.php"; ?>

<div id="content">
		<div id="main">
            <h1>Привет!!!!</h1>

            <form action="" method="post">
    <div class="form-group">
            <label for="id">Id</label>
            <input type="text" class="form-control is-valid" name="id" id="id"
                     placeholder="Id" value="<?= isset($data[0]['id']) ? $data[0]['id'] : '' ?>">            
    </div>
    <div class="form-group">
            <label for="title">Заголовок</label>
            <input type="text" class="form-control is-valid" name="title" id="title" 
                        placeholder="Заголовок" value="<?= isset($data[0]['title']) ? $data[0]['title'] : '' ?>">            
    </div>
    <div class="form-group">
            <label for="meta_k">Ключевые слова</label>
            <input type="text" class="form-control is-valid" name="meta_k" id="meta_k" 
                        placeholder="Ключевые слова" value="<?= isset($data[0]['meta_k']) ? $data[0]['meta_k'] : '' ?>">            
    </div>
    <button type="submit" class="btn btn-primary" name="saveChange" 
        value="<?= ($_GET['oper'] == 'edit') ? 'edit' : 'add' ?>">
        <?= ($_GET['oper'] == 'edit') ? 'Сохранить' : 'Добавить'?></button>
    <a href="index.php" class="btn btn-primary">Отмена</a>
</form>

		</div>


<?php include_once "inc/sidebar.php"; ?>

</div>


<?php include_once "inc/footer.php"; ?>